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
    [BindIndex("IX_IdentityResources_Name", true, "Name")]
    [BindTable("IdentityResources", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class IdentityResources : IIdentityResources
    {
        #region 属性
        private Int32 _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "", "INTEGER")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int64 _Enabled;
        /// <summary></summary>
        [DisplayName("Enabled")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enabled", "", "INTEGER")]
        public Int64 Enabled { get { return _Enabled; } set { if (OnPropertyChanging(__.Enabled, value)) { _Enabled = value; OnPropertyChanged(__.Enabled); } } }

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

        private String _Created;
        /// <summary></summary>
        [DisplayName("Created")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Created", "", "TEXT")]
        public String Created { get { return _Created; } set { if (OnPropertyChanging(__.Created, value)) { _Created = value; OnPropertyChanged(__.Created); } } }

        private String _Updated;
        /// <summary></summary>
        [DisplayName("Updated")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Updated", "", "TEXT")]
        public String Updated { get { return _Updated; } set { if (OnPropertyChanging(__.Updated, value)) { _Updated = value; OnPropertyChanged(__.Updated); } } }

        private Int64 _NonEditable;
        /// <summary></summary>
        [DisplayName("NonEditable")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NonEditable", "", "INTEGER")]
        public Int64 NonEditable { get { return _NonEditable; } set { if (OnPropertyChanging(__.NonEditable, value)) { _NonEditable = value; OnPropertyChanged(__.NonEditable); } } }
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
                    case __.Enabled : return _Enabled;
                    case __.Name : return _Name;
                    case __.DisplayName : return _DisplayName;
                    case __.Description : return _Description;
                    case __.Required : return _Required;
                    case __.Emphasize : return _Emphasize;
                    case __.ShowInDiscoveryDocument : return _ShowInDiscoveryDocument;
                    case __.Created : return _Created;
                    case __.Updated : return _Updated;
                    case __.NonEditable : return _NonEditable;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = value.ToInt(); break;
                    case __.Enabled : _Enabled = value.ToLong(); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.DisplayName : _DisplayName = Convert.ToString(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.Required : _Required = value.ToLong(); break;
                    case __.Emphasize : _Emphasize = value.ToLong(); break;
                    case __.ShowInDiscoveryDocument : _ShowInDiscoveryDocument = value.ToLong(); break;
                    case __.Created : _Created = Convert.ToString(value); break;
                    case __.Updated : _Updated = Convert.ToString(value); break;
                    case __.NonEditable : _NonEditable = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得IdentityResources字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field Enabled = FindByName(__.Enabled);

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
            public static readonly Field Created = FindByName(__.Created);

            /// <summary></summary>
            public static readonly Field Updated = FindByName(__.Updated);

            /// <summary></summary>
            public static readonly Field NonEditable = FindByName(__.NonEditable);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得IdentityResources字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String Enabled = "Enabled";

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
            public const String Created = "Created";

            /// <summary></summary>
            public const String Updated = "Updated";

            /// <summary></summary>
            public const String NonEditable = "NonEditable";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IIdentityResources
    {
        #region 属性
        /// <summary></summary>
        Int32 Id { get; set; }

        /// <summary></summary>
        Int64 Enabled { get; set; }

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
        String Created { get; set; }

        /// <summary></summary>
        String Updated { get; set; }

        /// <summary></summary>
        Int64 NonEditable { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}