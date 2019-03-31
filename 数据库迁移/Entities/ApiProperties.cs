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
    [BindIndex("IX_ApiProperties_ApiResourceId", false, "ApiResourceId")]
    [BindTable("ApiProperties", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class ApiProperties : IApiProperties
    {
        #region 属性
        private Int32 _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "", "INTEGER")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _Key;
        /// <summary></summary>
        [DisplayName("Key")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Key", "", "TEXT")]
        public String Key { get { return _Key; } set { if (OnPropertyChanging(__.Key, value)) { _Key = value; OnPropertyChanged(__.Key); } } }

        private String _Value;
        /// <summary></summary>
        [DisplayName("Value")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Value", "", "TEXT")]
        public String Value { get { return _Value; } set { if (OnPropertyChanging(__.Value, value)) { _Value = value; OnPropertyChanged(__.Value); } } }

        private Int64 _ApiResourceId;
        /// <summary></summary>
        [DisplayName("ApiResourceId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ApiResourceId", "", "INTEGER")]
        public Int64 ApiResourceId { get { return _ApiResourceId; } set { if (OnPropertyChanging(__.ApiResourceId, value)) { _ApiResourceId = value; OnPropertyChanged(__.ApiResourceId); } } }
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
                    case __.Key : return _Key;
                    case __.Value : return _Value;
                    case __.ApiResourceId : return _ApiResourceId;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = value.ToInt(); break;
                    case __.Key : _Key = Convert.ToString(value); break;
                    case __.Value : _Value = Convert.ToString(value); break;
                    case __.ApiResourceId : _ApiResourceId = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ApiProperties字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field Key = FindByName(__.Key);

            /// <summary></summary>
            public static readonly Field Value = FindByName(__.Value);

            /// <summary></summary>
            public static readonly Field ApiResourceId = FindByName(__.ApiResourceId);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ApiProperties字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String Key = "Key";

            /// <summary></summary>
            public const String Value = "Value";

            /// <summary></summary>
            public const String ApiResourceId = "ApiResourceId";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IApiProperties
    {
        #region 属性
        /// <summary></summary>
        Int32 Id { get; set; }

        /// <summary></summary>
        String Key { get; set; }

        /// <summary></summary>
        String Value { get; set; }

        /// <summary></summary>
        Int64 ApiResourceId { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}