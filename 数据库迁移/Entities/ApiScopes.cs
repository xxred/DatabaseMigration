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
    [BindIndex("IX_ApiScopes_ApiResourceId", false, "ApiResourceId")]
    [BindIndex("IX_ApiScopes_Name", true, "Name")]
    [BindTable("ApiScopes", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class ApiScopes : IApiScopes
    {
        #region 属性
        private Int32 _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "", "INTEGER")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _Name;
        /// <summary></summary>
        [DisplayName("Name")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Name", "", "TEXT", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _DisplayName;
        /// <summary></summary>
        [DisplayName("DisplayName")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DisplayName", "", "TEXT")]
        public String DisplayName { get { return _DisplayName; } set { if (OnPropertyChanging(__.DisplayName, value)) { _DisplayName = value; OnPropertyChanged(__.DisplayName); } } }

        private String _Description;
        /// <summary></summary>
        [DisplayName("Description")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Description", "", "TEXT")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }

        private Int64 _Required;
        /// <summary></summary>
        [DisplayName("Required")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Required", "", "INTEGER")]
        public Int64 Required { get { return _Required; } set { if (OnPropertyChanging(__.Required, value)) { _Required = value; OnPropertyChanged(__.Required); } } }

        private Int64 _Emphasize;
        /// <summary></summary>
        [DisplayName("Emphasize")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Emphasize", "", "INTEGER")]
        public Int64 Emphasize { get { return _Emphasize; } set { if (OnPropertyChanging(__.Emphasize, value)) { _Emphasize = value; OnPropertyChanged(__.Emphasize); } } }

        private Int64 _ShowInDiscoveryDocument;
        /// <summary></summary>
        [DisplayName("ShowInDiscoveryDocument")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ShowInDiscoveryDocument", "", "INTEGER")]
        public Int64 ShowInDiscoveryDocument { get { return _ShowInDiscoveryDocument; } set { if (OnPropertyChanging(__.ShowInDiscoveryDocument, value)) { _ShowInDiscoveryDocument = value; OnPropertyChanged(__.ShowInDiscoveryDocument); } } }

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
                    case __.Name : return _Name;
                    case __.DisplayName : return _DisplayName;
                    case __.Description : return _Description;
                    case __.Required : return _Required;
                    case __.Emphasize : return _Emphasize;
                    case __.ShowInDiscoveryDocument : return _ShowInDiscoveryDocument;
                    case __.ApiResourceId : return _ApiResourceId;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = value.ToInt(); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.DisplayName : _DisplayName = Convert.ToString(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.Required : _Required = value.ToLong(); break;
                    case __.Emphasize : _Emphasize = value.ToLong(); break;
                    case __.ShowInDiscoveryDocument : _ShowInDiscoveryDocument = value.ToLong(); break;
                    case __.ApiResourceId : _ApiResourceId = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ApiScopes字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary></summary>
            public static readonly Field DisplayName = FindByName(__.DisplayName);

            /// <summary></summary>
            public static readonly Field Description = FindByName(__.Description);

            /// <summary></summary>
            public static readonly Field Required = FindByName(__.Required);

            /// <summary></summary>
            public static readonly Field Emphasize = FindByName(__.Emphasize);

            /// <summary></summary>
            public static readonly Field ShowInDiscoveryDocument = FindByName(__.ShowInDiscoveryDocument);

            /// <summary></summary>
            public static readonly Field ApiResourceId = FindByName(__.ApiResourceId);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ApiScopes字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String Name = "Name";

            /// <summary></summary>
            public const String DisplayName = "DisplayName";

            /// <summary></summary>
            public const String Description = "Description";

            /// <summary></summary>
            public const String Required = "Required";

            /// <summary></summary>
            public const String Emphasize = "Emphasize";

            /// <summary></summary>
            public const String ShowInDiscoveryDocument = "ShowInDiscoveryDocument";

            /// <summary></summary>
            public const String ApiResourceId = "ApiResourceId";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IApiScopes
    {
        #region 属性
        /// <summary></summary>
        Int32 Id { get; set; }

        /// <summary></summary>
        String Name { get; set; }

        /// <summary></summary>
        String DisplayName { get; set; }

        /// <summary></summary>
        String Description { get; set; }

        /// <summary></summary>
        Int64 Required { get; set; }

        /// <summary></summary>
        Int64 Emphasize { get; set; }

        /// <summary></summary>
        Int64 ShowInDiscoveryDocument { get; set; }

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