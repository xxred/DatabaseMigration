using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using NewLife;
using NewLife.Data;
using NewLife.Log;
using NewLife.Model;
using NewLife.Reflection;
using NewLife.Threading;
using NewLife.Web;
using XCode;
using XCode.Cache;
using XCode.Configuration;
using XCode.DataAccessLayer;
using XCode.Membership;

namespace 数据库迁移.Entities
{
    /// <summary></summary>
    public partial class ApiResources : Entity<ApiResources>
    {
        #region 对象操作
        static ApiResources()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.Enabled);

            // 过滤器 UserModule、TimeModule、IPModule

            // 单对象缓存
            var sc = Meta.SingleCache;
            sc.FindSlaveKeyMethod = k => Find(__.Name, k);
            sc.GetSlaveKeyMethod = e => e.Name;
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 这里验证参数范围，建议抛出参数异常，指定参数名，前端用户界面可以捕获参数异常并聚焦到对应的参数输入框
            if (Name.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Name), "Name不能为空！");
            if (DisplayName.IsNullOrEmpty()) throw new ArgumentNullException(nameof(DisplayName), "DisplayName不能为空！");
            if (Description.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Description), "Description不能为空！");
            if (Created.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Created), "Created不能为空！");
            if (Updated.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Updated), "Updated不能为空！");
            if (LastAccessed.IsNullOrEmpty()) throw new ArgumentNullException(nameof(LastAccessed), "LastAccessed不能为空！");

            // 在新插入数据或者修改了指定字段时进行修正

            // 检查唯一索引
            // CheckExist(isNew, __.Name);
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化ApiResources[ApiResources]数据……");

        //    var entity = new ApiResources();
        //    entity.Id = 0;
        //    entity.Enabled = 0;
        //    entity.Name = "abc";
        //    entity.DisplayName = "abc";
        //    entity.Description = "abc";
        //    entity.Created = "abc";
        //    entity.Updated = "abc";
        //    entity.LastAccessed = "abc";
        //    entity.NonEditable = 0;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化ApiResources[ApiResources]数据！");
        //}

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnDelete()
        //{
        //    return base.OnDelete();
        //}
        #endregion

        #region 扩展属性
        #endregion

        #region 扩展查询
        /// <summary>根据Id查找</summary>
        /// <param name="id">Id</param>
        /// <returns>实体对象</returns>
        public static ApiResources FindById(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.Id == id);

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.Id == id);
        }

        /// <summary>根据Name查找</summary>
        /// <param name="name">Name</param>
        /// <returns>实体对象</returns>
        public static ApiResources FindByName(String name)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.Name == name);

            // 单对象缓存
            //return Meta.SingleCache.GetItemWithSlaveKey(name) as ApiResources;

            return Find(_.Name == name);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}