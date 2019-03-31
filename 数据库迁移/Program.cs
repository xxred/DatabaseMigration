using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using XCode;
using XCode.DataAccessLayer;
using 数据库迁移.Entities;

namespace 数据库迁移
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionStrConfig.AddConnectionStr();

            CopyDataBase("identityServer_sqlite", "identityServer_mysql");

            //ExcCopy("identityServer_sqlite", "identityServer_mysql");
        }

        /// <summary>
        /// 拷贝数据库，只需要数据库连接字符串和源数据库即可
        /// </summary>
        /// <param name="originConnName">源数据库连接字符串名</param>
        /// <param name="desConnName">目的数据库连接字符串名</param>
        /// <param name="perCount">每次获取的记录数目，如果默认-1则会自动调用函数计算一个合理值</param>
        public static void CopyDataBase(string originConnName, string desConnName, int perCount = -1)
        {
            //思路：通过源数据库获取架构信息，然后反向工程,然后导出数据            
            var dal = DAL.Create(originConnName);

            //获取源数据库的架构信息
            var tableList = new List<IDataTable>();

            // 处理表的架构信息
            foreach (var dataTable in dal.Tables)
            {
                //过滤掉视图
                if (dataTable.IsView) continue;

                // 2019-03-31 处理列名称，后续版本会修复此bug，不用此处理
                CheckColumnName(dataTable.Columns);

                // 修正列的类型
                FixColumns(dataTable.Columns);

                tableList.Add(dataTable);
            }

            dal.SyncAll(tableList.ToArray(), desConnName, true);
        }

        /// <summary>
        /// 通过实体操作接口批量拷贝数据库，也可作为分表分库功能使用
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="originConnName"></param>
        /// <param name="desConnName"></param>
        /// <param name="perCount"></param>
        public static void CopyDataTable(IEntityOperate factory, string originConnName, string desConnName, int perCount = -1)
        {
            //分页获取数据，并更新到新的数据库，通过更改数据库连接来完成

            FixColumns(factory.Table.DataTable.Columns);

            var allCount = factory.Count;
            var tableName = factory.TableName;

            if (perCount < 0) perCount = GetDataRowsPerConvert(allCount);
            var pages = (int)Math.Ceiling((double)((double)allCount / (double)perCount));

            for (var i = 0; i < pages; i++)
            {
                // 与上面代码等效
                factory.ConnName = originConnName;
                // factory.TableName = tableName;

                var modelList = factory.FindAll(string.Empty, string.Empty, string.Empty, i * perCount, perCount);
                factory.ConnName = desConnName;

                // 分表分库的时候，这里可加上判断是否分表的逻辑，即可将数据保存到分表
                // factory.TableName = tableName + DateTime.Now.ToString("yyyy-MM-dd");

                modelList.Insert(true);
            }
        }

        public static void ExcCopy(string originConnName, string desConnName, int perCount = -1)
        {
            var asm = typeof(ApiClaims).Assembly;
            var entityTypes = asm.GetTypes().Where(s => typeof(EntityBase).IsAssignableFrom(s)).ToArray();

            foreach (var entityType in entityTypes)
            {
                var factory = entityType.AsFactory();
                CopyDataTable(factory, originConnName, desConnName, perCount);
            }
        }

        /// <summary>
        /// 兼容处理，类型转换
        /// </summary>
        /// <param name="columns"></param>
        public static void FixColumns(List<IDataColumn> columns)
        {
            if (columns.Count < 1)
            {
                return;
            }

            var indexColumns = columns[0].Table.Indexes.SelectMany(s => s.Columns).ToArray();
            foreach (var column in columns)
            {
                // 主键、唯一、类型为text的全部修改为varchar(50)
                if ((!column.PrimaryKey &&
                     !indexColumns.Any(a => a.Equals(column.Name, StringComparison.OrdinalIgnoreCase))) ||
                    !column.RawType.Contains("text", StringComparison.OrdinalIgnoreCase)) continue;

                column.RawType = "varchar(50)";
                column.Length = 50;
            }
        }

        public static void CheckColumnName(List<IDataColumn> columns)
        {
            foreach (var dataTableColumn in columns)
            {
                if (dataTableColumn.Name.IsNullOrWhiteSpace())
                {
                    dataTableColumn.Name = dataTableColumn.ColumnName;
                }
            }
        }

        /// <summary>
        /// 根据数据表的记录总数来设置一个合理的每次转换数目。数据量大，一次性导出导入不合理
        /// </summary>
        /// <param name="allCount">数据表记录总数</param>
        /// <returns>每次转换的记录数</returns>
        private static int GetDataRowsPerConvert(int allCount)
        {
            if (allCount < 1000) return 200;
            else if (allCount < 5000) return 500;
            else if (allCount < 50000) return 1000;
            else return 1500;
        }
    }
}
