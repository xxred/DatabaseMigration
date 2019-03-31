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
    [BindIndex("IX_ApiScopeClaims_ApiScopeId", false, "ApiScopeId")]
    [BindTable("ApiScopeClaims", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class ApiScopeClaims : IApiScopeClaims
    {
        #region 属性
        private Int32 _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "", "INTEGER")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _Type;
        /// <summary></summary>
        [DisplayName("Type")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Type", "", "TEXT")]
        public String Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

        private Int64 _ApiScopeId;
        /// <summary></summary>
        [DisplayName("ApiScopeId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ApiScopeId", "", "INTEGER")]
        public Int64 ApiScopeId { get { return _ApiScopeId; } set { if (OnPropertyChanging(__.ApiScopeId, value)) { _ApiScopeId = value; OnPropertyChanged(__.ApiScopeId); } } }
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
                    case __.Type : return _Type;
                    case __.ApiScopeId : return _ApiScopeId;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = value.ToInt(); break;
                    case __.Type : _Type = Convert.ToString(value); break;
                    case __.ApiScopeId : _ApiScopeId = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ApiScopeClaims字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary></summary>
            public static readonly Field ApiScopeId = FindByName(__.ApiScopeId);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ApiScopeClaims字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String Type = "Type";

            /// <summary></summary>
            public const String ApiScopeId = "ApiScopeId";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IApiScopeClaims
    {
        #region 属性
        /// <summary></summary>
        Int32 Id { get; set; }

        /// <summary></summary>
        String Type { get; set; }

        /// <summary></summary>
        Int64 ApiScopeId { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}