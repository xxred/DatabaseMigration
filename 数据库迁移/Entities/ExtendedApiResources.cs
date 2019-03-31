using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace 数据库迁移.Entities
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [BindIndex("ApiNameIndex", true, "ApiResourceName")]
    [BindIndex("ApiResourceNameIndex", true, "NormalizedName")]
    [BindTable("ExtendedApiResources", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class ExtendedApiResources : IExtendedApiResources
    {
        #region 属性
        private String _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Id", "", "TEXT")]
        public String Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _ApiResourceName;
        /// <summary></summary>
        [DisplayName("ApiResourceName")]
        [DataObjectField(true, false, false, 0)]
        [BindColumn("ApiResourceName", "", "TEXT")]
        public String ApiResourceName { get { return _ApiResourceName; } set { if (OnPropertyChanging(__.ApiResourceName, value)) { _ApiResourceName = value; OnPropertyChanged(__.ApiResourceName); } } }

        private String _NormalizedName;
        /// <summary></summary>
        [DisplayName("NormalizedName")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalizedName", "", "TEXT")]
        public String NormalizedName { get { return _NormalizedName; } set { if (OnPropertyChanging(__.NormalizedName, value)) { _NormalizedName = value; OnPropertyChanged(__.NormalizedName); } } }

        private Int64 _Reserved;
        /// <summary></summary>
        [DisplayName("Reserved")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Reserved", "", "INTEGER")]
        public Int64 Reserved { get { return _Reserved; } set { if (OnPropertyChanging(__.Reserved, value)) { _Reserved = value; OnPropertyChanged(__.Reserved); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.Id : return _Id;
                    case __.ApiResourceName : return _ApiResourceName;
                    case __.NormalizedName : return _NormalizedName;
                    case __.Reserved : return _Reserved;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToString(value); break;
                    case __.ApiResourceName : _ApiResourceName = Convert.ToString(value); break;
                    case __.NormalizedName : _NormalizedName = Convert.ToString(value); break;
                    case __.Reserved : _Reserved = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ExtendedApiResources字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field ApiResourceName = FindByName(__.ApiResourceName);

            /// <summary></summary>
            public static readonly Field NormalizedName = FindByName(__.NormalizedName);

            /// <summary></summary>
            public static readonly Field Reserved = FindByName(__.Reserved);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ExtendedApiResources字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String ApiResourceName = "ApiResourceName";

            /// <summary></summary>
            public const String NormalizedName = "NormalizedName";

            /// <summary></summary>
            public const String Reserved = "Reserved";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IExtendedApiResources
    {
        #region 属性
        /// <summary></summary>
        String Id { get; set; }

        /// <summary></summary>
        String ApiResourceName { get; set; }

        /// <summary></summary>
        String NormalizedName { get; set; }

        /// <summary></summary>
        Int64 Reserved { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}