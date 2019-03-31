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
    [BindIndex("IdIndex", true, "ClientId")]
    [BindIndex("ClientIdIndex", true, "NormalizedClientId")]
    [BindIndex("ClientNameIndex", true, "NormalizedClientName")]
    [BindTable("ExtendedClients", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class ExtendedClients : IExtendedClients
    {
        #region 属性
        private String _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Id", "", "TEXT")]
        public String Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _ClientId;
        /// <summary></summary>
        [DisplayName("ClientId")]
        [DataObjectField(true, false, false, 0)]
        [BindColumn("ClientId", "", "TEXT")]
        public String ClientId { get { return _ClientId; } set { if (OnPropertyChanging(__.ClientId, value)) { _ClientId = value; OnPropertyChanged(__.ClientId); } } }

        private String _Description;
        /// <summary></summary>
        [DisplayName("Description")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Description", "", "TEXT")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }

        private String _NormalizedClientId;
        /// <summary></summary>
        [DisplayName("NormalizedClientId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalizedClientId", "", "TEXT")]
        public String NormalizedClientId { get { return _NormalizedClientId; } set { if (OnPropertyChanging(__.NormalizedClientId, value)) { _NormalizedClientId = value; OnPropertyChanged(__.NormalizedClientId); } } }

        private String _NormalizedClientName;
        /// <summary></summary>
        [DisplayName("NormalizedClientName")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalizedClientName", "", "TEXT")]
        public String NormalizedClientName { get { return _NormalizedClientName; } set { if (OnPropertyChanging(__.NormalizedClientName, value)) { _NormalizedClientName = value; OnPropertyChanged(__.NormalizedClientName); } } }

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
                    case __.ClientId : return _ClientId;
                    case __.Description : return _Description;
                    case __.NormalizedClientId : return _NormalizedClientId;
                    case __.NormalizedClientName : return _NormalizedClientName;
                    case __.Reserved : return _Reserved;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToString(value); break;
                    case __.ClientId : _ClientId = Convert.ToString(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.NormalizedClientId : _NormalizedClientId = Convert.ToString(value); break;
                    case __.NormalizedClientName : _NormalizedClientName = Convert.ToString(value); break;
                    case __.Reserved : _Reserved = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ExtendedClients字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field ClientId = FindByName(__.ClientId);

            /// <summary></summary>
            public static readonly Field Description = FindByName(__.Description);

            /// <summary></summary>
            public static readonly Field NormalizedClientId = FindByName(__.NormalizedClientId);

            /// <summary></summary>
            public static readonly Field NormalizedClientName = FindByName(__.NormalizedClientName);

            /// <summary></summary>
            public static readonly Field Reserved = FindByName(__.Reserved);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ExtendedClients字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String ClientId = "ClientId";

            /// <summary></summary>
            public const String Description = "Description";

            /// <summary></summary>
            public const String NormalizedClientId = "NormalizedClientId";

            /// <summary></summary>
            public const String NormalizedClientName = "NormalizedClientName";

            /// <summary></summary>
            public const String Reserved = "Reserved";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IExtendedClients
    {
        #region 属性
        /// <summary></summary>
        String Id { get; set; }

        /// <summary></summary>
        String ClientId { get; set; }

        /// <summary></summary>
        String Description { get; set; }

        /// <summary></summary>
        String NormalizedClientId { get; set; }

        /// <summary></summary>
        String NormalizedClientName { get; set; }

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