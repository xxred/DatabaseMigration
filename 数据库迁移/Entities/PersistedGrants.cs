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
    [BindIndex("IX_PersistedGrants_SubjectId_ClientId_Type", false, "SubjectId,ClientId,Type")]
    [BindTable("PersistedGrants", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class PersistedGrants : IPersistedGrants
    {
        #region 属性
        private String _Key;
        /// <summary></summary>
        [DisplayName("Key")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Key", "", "TEXT")]
        public String Key { get { return _Key; } set { if (OnPropertyChanging(__.Key, value)) { _Key = value; OnPropertyChanged(__.Key); } } }

        private String _Type;
        /// <summary></summary>
        [DisplayName("Type")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Type", "", "TEXT")]
        public String Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

        private String _SubjectId;
        /// <summary></summary>
        [DisplayName("SubjectId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SubjectId", "", "TEXT")]
        public String SubjectId { get { return _SubjectId; } set { if (OnPropertyChanging(__.SubjectId, value)) { _SubjectId = value; OnPropertyChanged(__.SubjectId); } } }

        private String _ClientId;
        /// <summary></summary>
        [DisplayName("ClientId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClientId", "", "TEXT")]
        public String ClientId { get { return _ClientId; } set { if (OnPropertyChanging(__.ClientId, value)) { _ClientId = value; OnPropertyChanged(__.ClientId); } } }

        private String _CreationTime;
        /// <summary></summary>
        [DisplayName("CreationTime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreationTime", "", "TEXT")]
        public String CreationTime { get { return _CreationTime; } set { if (OnPropertyChanging(__.CreationTime, value)) { _CreationTime = value; OnPropertyChanged(__.CreationTime); } } }

        private String _Expiration;
        /// <summary></summary>
        [DisplayName("Expiration")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Expiration", "", "TEXT")]
        public String Expiration { get { return _Expiration; } set { if (OnPropertyChanging(__.Expiration, value)) { _Expiration = value; OnPropertyChanged(__.Expiration); } } }

        private String _Data;
        /// <summary></summary>
        [DisplayName("Data")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Data", "", "TEXT")]
        public String Data { get { return _Data; } set { if (OnPropertyChanging(__.Data, value)) { _Data = value; OnPropertyChanged(__.Data); } } }
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
                    case __.Key : return _Key;
                    case __.Type : return _Type;
                    case __.SubjectId : return _SubjectId;
                    case __.ClientId : return _ClientId;
                    case __.CreationTime : return _CreationTime;
                    case __.Expiration : return _Expiration;
                    case __.Data : return _Data;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Key : _Key = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToString(value); break;
                    case __.SubjectId : _SubjectId = Convert.ToString(value); break;
                    case __.ClientId : _ClientId = Convert.ToString(value); break;
                    case __.CreationTime : _CreationTime = Convert.ToString(value); break;
                    case __.Expiration : _Expiration = Convert.ToString(value); break;
                    case __.Data : _Data = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得PersistedGrants字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Key = FindByName(__.Key);

            /// <summary></summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary></summary>
            public static readonly Field SubjectId = FindByName(__.SubjectId);

            /// <summary></summary>
            public static readonly Field ClientId = FindByName(__.ClientId);

            /// <summary></summary>
            public static readonly Field CreationTime = FindByName(__.CreationTime);

            /// <summary></summary>
            public static readonly Field Expiration = FindByName(__.Expiration);

            /// <summary></summary>
            public static readonly Field Data = FindByName(__.Data);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得PersistedGrants字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Key = "Key";

            /// <summary></summary>
            public const String Type = "Type";

            /// <summary></summary>
            public const String SubjectId = "SubjectId";

            /// <summary></summary>
            public const String ClientId = "ClientId";

            /// <summary></summary>
            public const String CreationTime = "CreationTime";

            /// <summary></summary>
            public const String Expiration = "Expiration";

            /// <summary></summary>
            public const String Data = "Data";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IPersistedGrants
    {
        #region 属性
        /// <summary></summary>
        String Key { get; set; }

        /// <summary></summary>
        String Type { get; set; }

        /// <summary></summary>
        String SubjectId { get; set; }

        /// <summary></summary>
        String ClientId { get; set; }

        /// <summary></summary>
        String CreationTime { get; set; }

        /// <summary></summary>
        String Expiration { get; set; }

        /// <summary></summary>
        String Data { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}