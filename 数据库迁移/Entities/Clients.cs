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
    [BindIndex("IX_Clients_ClientId", true, "ClientId")]
    [BindTable("Clients", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class Clients : IClients
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

        private String _ClientId;
        /// <summary></summary>
        [DisplayName("ClientId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClientId", "", "TEXT")]
        public String ClientId { get { return _ClientId; } set { if (OnPropertyChanging(__.ClientId, value)) { _ClientId = value; OnPropertyChanged(__.ClientId); } } }

        private String _ProtocolType;
        /// <summary></summary>
        [DisplayName("ProtocolType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ProtocolType", "", "TEXT")]
        public String ProtocolType { get { return _ProtocolType; } set { if (OnPropertyChanging(__.ProtocolType, value)) { _ProtocolType = value; OnPropertyChanged(__.ProtocolType); } } }

        private Int64 _RequireClientSecret;
        /// <summary></summary>
        [DisplayName("RequireClientSecret")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RequireClientSecret", "", "INTEGER")]
        public Int64 RequireClientSecret { get { return _RequireClientSecret; } set { if (OnPropertyChanging(__.RequireClientSecret, value)) { _RequireClientSecret = value; OnPropertyChanged(__.RequireClientSecret); } } }

        private String _ClientName;
        /// <summary></summary>
        [DisplayName("ClientName")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClientName", "", "TEXT")]
        public String ClientName { get { return _ClientName; } set { if (OnPropertyChanging(__.ClientName, value)) { _ClientName = value; OnPropertyChanged(__.ClientName); } } }

        private String _Description;
        /// <summary></summary>
        [DisplayName("Description")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Description", "", "TEXT")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }

        private String _ClientUri;
        /// <summary></summary>
        [DisplayName("ClientUri")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClientUri", "", "TEXT")]
        public String ClientUri { get { return _ClientUri; } set { if (OnPropertyChanging(__.ClientUri, value)) { _ClientUri = value; OnPropertyChanged(__.ClientUri); } } }

        private String _LogoUri;
        /// <summary></summary>
        [DisplayName("LogoUri")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("LogoUri", "", "TEXT")]
        public String LogoUri { get { return _LogoUri; } set { if (OnPropertyChanging(__.LogoUri, value)) { _LogoUri = value; OnPropertyChanged(__.LogoUri); } } }

        private Int64 _RequireConsent;
        /// <summary></summary>
        [DisplayName("RequireConsent")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RequireConsent", "", "INTEGER")]
        public Int64 RequireConsent { get { return _RequireConsent; } set { if (OnPropertyChanging(__.RequireConsent, value)) { _RequireConsent = value; OnPropertyChanged(__.RequireConsent); } } }

        private Int64 _AllowRememberConsent;
        /// <summary></summary>
        [DisplayName("AllowRememberConsent")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AllowRememberConsent", "", "INTEGER")]
        public Int64 AllowRememberConsent { get { return _AllowRememberConsent; } set { if (OnPropertyChanging(__.AllowRememberConsent, value)) { _AllowRememberConsent = value; OnPropertyChanged(__.AllowRememberConsent); } } }

        private Int64 _AlwaysIncludeUserClaimsInIdToken;
        /// <summary></summary>
        [DisplayName("AlwaysIncludeUserClaimsInIdToken")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AlwaysIncludeUserClaimsInIdToken", "", "INTEGER")]
        public Int64 AlwaysIncludeUserClaimsInIdToken { get { return _AlwaysIncludeUserClaimsInIdToken; } set { if (OnPropertyChanging(__.AlwaysIncludeUserClaimsInIdToken, value)) { _AlwaysIncludeUserClaimsInIdToken = value; OnPropertyChanged(__.AlwaysIncludeUserClaimsInIdToken); } } }

        private Int64 _RequirePkce;
        /// <summary></summary>
        [DisplayName("RequirePkce")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RequirePkce", "", "INTEGER")]
        public Int64 RequirePkce { get { return _RequirePkce; } set { if (OnPropertyChanging(__.RequirePkce, value)) { _RequirePkce = value; OnPropertyChanged(__.RequirePkce); } } }

        private Int64 _AllowPlainTextPkce;
        /// <summary></summary>
        [DisplayName("AllowPlainTextPkce")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AllowPlainTextPkce", "", "INTEGER")]
        public Int64 AllowPlainTextPkce { get { return _AllowPlainTextPkce; } set { if (OnPropertyChanging(__.AllowPlainTextPkce, value)) { _AllowPlainTextPkce = value; OnPropertyChanged(__.AllowPlainTextPkce); } } }

        private Int64 _AllowAccessTokensViaBrowser;
        /// <summary></summary>
        [DisplayName("AllowAccessTokensViaBrowser")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AllowAccessTokensViaBrowser", "", "INTEGER")]
        public Int64 AllowAccessTokensViaBrowser { get { return _AllowAccessTokensViaBrowser; } set { if (OnPropertyChanging(__.AllowAccessTokensViaBrowser, value)) { _AllowAccessTokensViaBrowser = value; OnPropertyChanged(__.AllowAccessTokensViaBrowser); } } }

        private String _FrontChannelLogoutUri;
        /// <summary></summary>
        [DisplayName("FrontChannelLogoutUri")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("FrontChannelLogoutUri", "", "TEXT")]
        public String FrontChannelLogoutUri { get { return _FrontChannelLogoutUri; } set { if (OnPropertyChanging(__.FrontChannelLogoutUri, value)) { _FrontChannelLogoutUri = value; OnPropertyChanged(__.FrontChannelLogoutUri); } } }

        private Int64 _FrontChannelLogoutSessionRequired;
        /// <summary></summary>
        [DisplayName("FrontChannelLogoutSessionRequired")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("FrontChannelLogoutSessionRequired", "", "INTEGER")]
        public Int64 FrontChannelLogoutSessionRequired { get { return _FrontChannelLogoutSessionRequired; } set { if (OnPropertyChanging(__.FrontChannelLogoutSessionRequired, value)) { _FrontChannelLogoutSessionRequired = value; OnPropertyChanged(__.FrontChannelLogoutSessionRequired); } } }

        private String _BackChannelLogoutUri;
        /// <summary></summary>
        [DisplayName("BackChannelLogoutUri")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("BackChannelLogoutUri", "", "TEXT")]
        public String BackChannelLogoutUri { get { return _BackChannelLogoutUri; } set { if (OnPropertyChanging(__.BackChannelLogoutUri, value)) { _BackChannelLogoutUri = value; OnPropertyChanged(__.BackChannelLogoutUri); } } }

        private Int64 _BackChannelLogoutSessionRequired;
        /// <summary></summary>
        [DisplayName("BackChannelLogoutSessionRequired")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("BackChannelLogoutSessionRequired", "", "INTEGER")]
        public Int64 BackChannelLogoutSessionRequired { get { return _BackChannelLogoutSessionRequired; } set { if (OnPropertyChanging(__.BackChannelLogoutSessionRequired, value)) { _BackChannelLogoutSessionRequired = value; OnPropertyChanged(__.BackChannelLogoutSessionRequired); } } }

        private Int64 _AllowOfflineAccess;
        /// <summary></summary>
        [DisplayName("AllowOfflineAccess")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AllowOfflineAccess", "", "INTEGER")]
        public Int64 AllowOfflineAccess { get { return _AllowOfflineAccess; } set { if (OnPropertyChanging(__.AllowOfflineAccess, value)) { _AllowOfflineAccess = value; OnPropertyChanged(__.AllowOfflineAccess); } } }

        private Int64 _IdentityTokenLifetime;
        /// <summary></summary>
        [DisplayName("IdentityTokenLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IdentityTokenLifetime", "", "INTEGER")]
        public Int64 IdentityTokenLifetime { get { return _IdentityTokenLifetime; } set { if (OnPropertyChanging(__.IdentityTokenLifetime, value)) { _IdentityTokenLifetime = value; OnPropertyChanged(__.IdentityTokenLifetime); } } }

        private Int64 _AccessTokenLifetime;
        /// <summary></summary>
        [DisplayName("AccessTokenLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AccessTokenLifetime", "", "INTEGER")]
        public Int64 AccessTokenLifetime { get { return _AccessTokenLifetime; } set { if (OnPropertyChanging(__.AccessTokenLifetime, value)) { _AccessTokenLifetime = value; OnPropertyChanged(__.AccessTokenLifetime); } } }

        private Int64 _AuthorizationCodeLifetime;
        /// <summary></summary>
        [DisplayName("AuthorizationCodeLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AuthorizationCodeLifetime", "", "INTEGER")]
        public Int64 AuthorizationCodeLifetime { get { return _AuthorizationCodeLifetime; } set { if (OnPropertyChanging(__.AuthorizationCodeLifetime, value)) { _AuthorizationCodeLifetime = value; OnPropertyChanged(__.AuthorizationCodeLifetime); } } }

        private Int64 _ConsentLifetime;
        /// <summary></summary>
        [DisplayName("ConsentLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ConsentLifetime", "", "INTEGER")]
        public Int64 ConsentLifetime { get { return _ConsentLifetime; } set { if (OnPropertyChanging(__.ConsentLifetime, value)) { _ConsentLifetime = value; OnPropertyChanged(__.ConsentLifetime); } } }

        private Int64 _AbsoluteRefreshTokenLifetime;
        /// <summary></summary>
        [DisplayName("AbsoluteRefreshTokenLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AbsoluteRefreshTokenLifetime", "", "INTEGER")]
        public Int64 AbsoluteRefreshTokenLifetime { get { return _AbsoluteRefreshTokenLifetime; } set { if (OnPropertyChanging(__.AbsoluteRefreshTokenLifetime, value)) { _AbsoluteRefreshTokenLifetime = value; OnPropertyChanged(__.AbsoluteRefreshTokenLifetime); } } }

        private Int64 _SlidingRefreshTokenLifetime;
        /// <summary></summary>
        [DisplayName("SlidingRefreshTokenLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SlidingRefreshTokenLifetime", "", "INTEGER")]
        public Int64 SlidingRefreshTokenLifetime { get { return _SlidingRefreshTokenLifetime; } set { if (OnPropertyChanging(__.SlidingRefreshTokenLifetime, value)) { _SlidingRefreshTokenLifetime = value; OnPropertyChanged(__.SlidingRefreshTokenLifetime); } } }

        private Int64 _RefreshTokenUsage;
        /// <summary></summary>
        [DisplayName("RefreshTokenUsage")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RefreshTokenUsage", "", "INTEGER")]
        public Int64 RefreshTokenUsage { get { return _RefreshTokenUsage; } set { if (OnPropertyChanging(__.RefreshTokenUsage, value)) { _RefreshTokenUsage = value; OnPropertyChanged(__.RefreshTokenUsage); } } }

        private Int64 _UpdateAccessTokenClaimsOnRefresh;
        /// <summary></summary>
        [DisplayName("UpdateAccessTokenClaimsOnRefresh")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateAccessTokenClaimsOnRefresh", "", "INTEGER")]
        public Int64 UpdateAccessTokenClaimsOnRefresh { get { return _UpdateAccessTokenClaimsOnRefresh; } set { if (OnPropertyChanging(__.UpdateAccessTokenClaimsOnRefresh, value)) { _UpdateAccessTokenClaimsOnRefresh = value; OnPropertyChanged(__.UpdateAccessTokenClaimsOnRefresh); } } }

        private Int64 _RefreshTokenExpiration;
        /// <summary></summary>
        [DisplayName("RefreshTokenExpiration")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RefreshTokenExpiration", "", "INTEGER")]
        public Int64 RefreshTokenExpiration { get { return _RefreshTokenExpiration; } set { if (OnPropertyChanging(__.RefreshTokenExpiration, value)) { _RefreshTokenExpiration = value; OnPropertyChanged(__.RefreshTokenExpiration); } } }

        private Int64 _AccessTokenType;
        /// <summary></summary>
        [DisplayName("AccessTokenType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AccessTokenType", "", "INTEGER")]
        public Int64 AccessTokenType { get { return _AccessTokenType; } set { if (OnPropertyChanging(__.AccessTokenType, value)) { _AccessTokenType = value; OnPropertyChanged(__.AccessTokenType); } } }

        private Int64 _EnableLocalLogin;
        /// <summary></summary>
        [DisplayName("EnableLocalLogin")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("EnableLocalLogin", "", "INTEGER")]
        public Int64 EnableLocalLogin { get { return _EnableLocalLogin; } set { if (OnPropertyChanging(__.EnableLocalLogin, value)) { _EnableLocalLogin = value; OnPropertyChanged(__.EnableLocalLogin); } } }

        private Int64 _IncludeJwtId;
        /// <summary></summary>
        [DisplayName("IncludeJwtId")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IncludeJwtId", "", "INTEGER")]
        public Int64 IncludeJwtId { get { return _IncludeJwtId; } set { if (OnPropertyChanging(__.IncludeJwtId, value)) { _IncludeJwtId = value; OnPropertyChanged(__.IncludeJwtId); } } }

        private Int64 _AlwaysSendClientClaims;
        /// <summary></summary>
        [DisplayName("AlwaysSendClientClaims")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AlwaysSendClientClaims", "", "INTEGER")]
        public Int64 AlwaysSendClientClaims { get { return _AlwaysSendClientClaims; } set { if (OnPropertyChanging(__.AlwaysSendClientClaims, value)) { _AlwaysSendClientClaims = value; OnPropertyChanged(__.AlwaysSendClientClaims); } } }

        private String _ClientClaimsPrefix;
        /// <summary></summary>
        [DisplayName("ClientClaimsPrefix")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClientClaimsPrefix", "", "TEXT")]
        public String ClientClaimsPrefix { get { return _ClientClaimsPrefix; } set { if (OnPropertyChanging(__.ClientClaimsPrefix, value)) { _ClientClaimsPrefix = value; OnPropertyChanged(__.ClientClaimsPrefix); } } }

        private String _PairWiseSubjectSalt;
        /// <summary></summary>
        [DisplayName("PairWiseSubjectSalt")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("PairWiseSubjectSalt", "", "TEXT")]
        public String PairWiseSubjectSalt { get { return _PairWiseSubjectSalt; } set { if (OnPropertyChanging(__.PairWiseSubjectSalt, value)) { _PairWiseSubjectSalt = value; OnPropertyChanged(__.PairWiseSubjectSalt); } } }

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

        private String _LastAccessed;
        /// <summary></summary>
        [DisplayName("LastAccessed")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("LastAccessed", "", "TEXT")]
        public String LastAccessed { get { return _LastAccessed; } set { if (OnPropertyChanging(__.LastAccessed, value)) { _LastAccessed = value; OnPropertyChanged(__.LastAccessed); } } }

        private Int64 _UserSsoLifetime;
        /// <summary></summary>
        [DisplayName("UserSsoLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UserSsoLifetime", "", "INTEGER")]
        public Int64 UserSsoLifetime { get { return _UserSsoLifetime; } set { if (OnPropertyChanging(__.UserSsoLifetime, value)) { _UserSsoLifetime = value; OnPropertyChanged(__.UserSsoLifetime); } } }

        private String _UserCodeType;
        /// <summary></summary>
        [DisplayName("UserCodeType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UserCodeType", "", "TEXT")]
        public String UserCodeType { get { return _UserCodeType; } set { if (OnPropertyChanging(__.UserCodeType, value)) { _UserCodeType = value; OnPropertyChanged(__.UserCodeType); } } }

        private Int64 _DeviceCodeLifetime;
        /// <summary></summary>
        [DisplayName("DeviceCodeLifetime")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DeviceCodeLifetime", "", "INTEGER")]
        public Int64 DeviceCodeLifetime { get { return _DeviceCodeLifetime; } set { if (OnPropertyChanging(__.DeviceCodeLifetime, value)) { _DeviceCodeLifetime = value; OnPropertyChanged(__.DeviceCodeLifetime); } } }

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
                    case __.ClientId : return _ClientId;
                    case __.ProtocolType : return _ProtocolType;
                    case __.RequireClientSecret : return _RequireClientSecret;
                    case __.ClientName : return _ClientName;
                    case __.Description : return _Description;
                    case __.ClientUri : return _ClientUri;
                    case __.LogoUri : return _LogoUri;
                    case __.RequireConsent : return _RequireConsent;
                    case __.AllowRememberConsent : return _AllowRememberConsent;
                    case __.AlwaysIncludeUserClaimsInIdToken : return _AlwaysIncludeUserClaimsInIdToken;
                    case __.RequirePkce : return _RequirePkce;
                    case __.AllowPlainTextPkce : return _AllowPlainTextPkce;
                    case __.AllowAccessTokensViaBrowser : return _AllowAccessTokensViaBrowser;
                    case __.FrontChannelLogoutUri : return _FrontChannelLogoutUri;
                    case __.FrontChannelLogoutSessionRequired : return _FrontChannelLogoutSessionRequired;
                    case __.BackChannelLogoutUri : return _BackChannelLogoutUri;
                    case __.BackChannelLogoutSessionRequired : return _BackChannelLogoutSessionRequired;
                    case __.AllowOfflineAccess : return _AllowOfflineAccess;
                    case __.IdentityTokenLifetime : return _IdentityTokenLifetime;
                    case __.AccessTokenLifetime : return _AccessTokenLifetime;
                    case __.AuthorizationCodeLifetime : return _AuthorizationCodeLifetime;
                    case __.ConsentLifetime : return _ConsentLifetime;
                    case __.AbsoluteRefreshTokenLifetime : return _AbsoluteRefreshTokenLifetime;
                    case __.SlidingRefreshTokenLifetime : return _SlidingRefreshTokenLifetime;
                    case __.RefreshTokenUsage : return _RefreshTokenUsage;
                    case __.UpdateAccessTokenClaimsOnRefresh : return _UpdateAccessTokenClaimsOnRefresh;
                    case __.RefreshTokenExpiration : return _RefreshTokenExpiration;
                    case __.AccessTokenType : return _AccessTokenType;
                    case __.EnableLocalLogin : return _EnableLocalLogin;
                    case __.IncludeJwtId : return _IncludeJwtId;
                    case __.AlwaysSendClientClaims : return _AlwaysSendClientClaims;
                    case __.ClientClaimsPrefix : return _ClientClaimsPrefix;
                    case __.PairWiseSubjectSalt : return _PairWiseSubjectSalt;
                    case __.Created : return _Created;
                    case __.Updated : return _Updated;
                    case __.LastAccessed : return _LastAccessed;
                    case __.UserSsoLifetime : return _UserSsoLifetime;
                    case __.UserCodeType : return _UserCodeType;
                    case __.DeviceCodeLifetime : return _DeviceCodeLifetime;
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
                    case __.ClientId : _ClientId = Convert.ToString(value); break;
                    case __.ProtocolType : _ProtocolType = Convert.ToString(value); break;
                    case __.RequireClientSecret : _RequireClientSecret = value.ToLong(); break;
                    case __.ClientName : _ClientName = Convert.ToString(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.ClientUri : _ClientUri = Convert.ToString(value); break;
                    case __.LogoUri : _LogoUri = Convert.ToString(value); break;
                    case __.RequireConsent : _RequireConsent = value.ToLong(); break;
                    case __.AllowRememberConsent : _AllowRememberConsent = value.ToLong(); break;
                    case __.AlwaysIncludeUserClaimsInIdToken : _AlwaysIncludeUserClaimsInIdToken = value.ToLong(); break;
                    case __.RequirePkce : _RequirePkce = value.ToLong(); break;
                    case __.AllowPlainTextPkce : _AllowPlainTextPkce = value.ToLong(); break;
                    case __.AllowAccessTokensViaBrowser : _AllowAccessTokensViaBrowser = value.ToLong(); break;
                    case __.FrontChannelLogoutUri : _FrontChannelLogoutUri = Convert.ToString(value); break;
                    case __.FrontChannelLogoutSessionRequired : _FrontChannelLogoutSessionRequired = value.ToLong(); break;
                    case __.BackChannelLogoutUri : _BackChannelLogoutUri = Convert.ToString(value); break;
                    case __.BackChannelLogoutSessionRequired : _BackChannelLogoutSessionRequired = value.ToLong(); break;
                    case __.AllowOfflineAccess : _AllowOfflineAccess = value.ToLong(); break;
                    case __.IdentityTokenLifetime : _IdentityTokenLifetime = value.ToLong(); break;
                    case __.AccessTokenLifetime : _AccessTokenLifetime = value.ToLong(); break;
                    case __.AuthorizationCodeLifetime : _AuthorizationCodeLifetime = value.ToLong(); break;
                    case __.ConsentLifetime : _ConsentLifetime = value.ToLong(); break;
                    case __.AbsoluteRefreshTokenLifetime : _AbsoluteRefreshTokenLifetime = value.ToLong(); break;
                    case __.SlidingRefreshTokenLifetime : _SlidingRefreshTokenLifetime = value.ToLong(); break;
                    case __.RefreshTokenUsage : _RefreshTokenUsage = value.ToLong(); break;
                    case __.UpdateAccessTokenClaimsOnRefresh : _UpdateAccessTokenClaimsOnRefresh = value.ToLong(); break;
                    case __.RefreshTokenExpiration : _RefreshTokenExpiration = value.ToLong(); break;
                    case __.AccessTokenType : _AccessTokenType = value.ToLong(); break;
                    case __.EnableLocalLogin : _EnableLocalLogin = value.ToLong(); break;
                    case __.IncludeJwtId : _IncludeJwtId = value.ToLong(); break;
                    case __.AlwaysSendClientClaims : _AlwaysSendClientClaims = value.ToLong(); break;
                    case __.ClientClaimsPrefix : _ClientClaimsPrefix = Convert.ToString(value); break;
                    case __.PairWiseSubjectSalt : _PairWiseSubjectSalt = Convert.ToString(value); break;
                    case __.Created : _Created = Convert.ToString(value); break;
                    case __.Updated : _Updated = Convert.ToString(value); break;
                    case __.LastAccessed : _LastAccessed = Convert.ToString(value); break;
                    case __.UserSsoLifetime : _UserSsoLifetime = value.ToLong(); break;
                    case __.UserCodeType : _UserCodeType = Convert.ToString(value); break;
                    case __.DeviceCodeLifetime : _DeviceCodeLifetime = value.ToLong(); break;
                    case __.NonEditable : _NonEditable = value.ToLong(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得Clients字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field Enabled = FindByName(__.Enabled);

            /// <summary></summary>
            public static readonly Field ClientId = FindByName(__.ClientId);

            /// <summary></summary>
            public static readonly Field ProtocolType = FindByName(__.ProtocolType);

            /// <summary></summary>
            public static readonly Field RequireClientSecret = FindByName(__.RequireClientSecret);

            /// <summary></summary>
            public static readonly Field ClientName = FindByName(__.ClientName);

            /// <summary></summary>
            public static readonly Field Description = FindByName(__.Description);

            /// <summary></summary>
            public static readonly Field ClientUri = FindByName(__.ClientUri);

            /// <summary></summary>
            public static readonly Field LogoUri = FindByName(__.LogoUri);

            /// <summary></summary>
            public static readonly Field RequireConsent = FindByName(__.RequireConsent);

            /// <summary></summary>
            public static readonly Field AllowRememberConsent = FindByName(__.AllowRememberConsent);

            /// <summary></summary>
            public static readonly Field AlwaysIncludeUserClaimsInIdToken = FindByName(__.AlwaysIncludeUserClaimsInIdToken);

            /// <summary></summary>
            public static readonly Field RequirePkce = FindByName(__.RequirePkce);

            /// <summary></summary>
            public static readonly Field AllowPlainTextPkce = FindByName(__.AllowPlainTextPkce);

            /// <summary></summary>
            public static readonly Field AllowAccessTokensViaBrowser = FindByName(__.AllowAccessTokensViaBrowser);

            /// <summary></summary>
            public static readonly Field FrontChannelLogoutUri = FindByName(__.FrontChannelLogoutUri);

            /// <summary></summary>
            public static readonly Field FrontChannelLogoutSessionRequired = FindByName(__.FrontChannelLogoutSessionRequired);

            /// <summary></summary>
            public static readonly Field BackChannelLogoutUri = FindByName(__.BackChannelLogoutUri);

            /// <summary></summary>
            public static readonly Field BackChannelLogoutSessionRequired = FindByName(__.BackChannelLogoutSessionRequired);

            /// <summary></summary>
            public static readonly Field AllowOfflineAccess = FindByName(__.AllowOfflineAccess);

            /// <summary></summary>
            public static readonly Field IdentityTokenLifetime = FindByName(__.IdentityTokenLifetime);

            /// <summary></summary>
            public static readonly Field AccessTokenLifetime = FindByName(__.AccessTokenLifetime);

            /// <summary></summary>
            public static readonly Field AuthorizationCodeLifetime = FindByName(__.AuthorizationCodeLifetime);

            /// <summary></summary>
            public static readonly Field ConsentLifetime = FindByName(__.ConsentLifetime);

            /// <summary></summary>
            public static readonly Field AbsoluteRefreshTokenLifetime = FindByName(__.AbsoluteRefreshTokenLifetime);

            /// <summary></summary>
            public static readonly Field SlidingRefreshTokenLifetime = FindByName(__.SlidingRefreshTokenLifetime);

            /// <summary></summary>
            public static readonly Field RefreshTokenUsage = FindByName(__.RefreshTokenUsage);

            /// <summary></summary>
            public static readonly Field UpdateAccessTokenClaimsOnRefresh = FindByName(__.UpdateAccessTokenClaimsOnRefresh);

            /// <summary></summary>
            public static readonly Field RefreshTokenExpiration = FindByName(__.RefreshTokenExpiration);

            /// <summary></summary>
            public static readonly Field AccessTokenType = FindByName(__.AccessTokenType);

            /// <summary></summary>
            public static readonly Field EnableLocalLogin = FindByName(__.EnableLocalLogin);

            /// <summary></summary>
            public static readonly Field IncludeJwtId = FindByName(__.IncludeJwtId);

            /// <summary></summary>
            public static readonly Field AlwaysSendClientClaims = FindByName(__.AlwaysSendClientClaims);

            /// <summary></summary>
            public static readonly Field ClientClaimsPrefix = FindByName(__.ClientClaimsPrefix);

            /// <summary></summary>
            public static readonly Field PairWiseSubjectSalt = FindByName(__.PairWiseSubjectSalt);

            /// <summary></summary>
            public static readonly Field Created = FindByName(__.Created);

            /// <summary></summary>
            public static readonly Field Updated = FindByName(__.Updated);

            /// <summary></summary>
            public static readonly Field LastAccessed = FindByName(__.LastAccessed);

            /// <summary></summary>
            public static readonly Field UserSsoLifetime = FindByName(__.UserSsoLifetime);

            /// <summary></summary>
            public static readonly Field UserCodeType = FindByName(__.UserCodeType);

            /// <summary></summary>
            public static readonly Field DeviceCodeLifetime = FindByName(__.DeviceCodeLifetime);

            /// <summary></summary>
            public static readonly Field NonEditable = FindByName(__.NonEditable);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得Clients字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String Enabled = "Enabled";

            /// <summary></summary>
            public const String ClientId = "ClientId";

            /// <summary></summary>
            public const String ProtocolType = "ProtocolType";

            /// <summary></summary>
            public const String RequireClientSecret = "RequireClientSecret";

            /// <summary></summary>
            public const String ClientName = "ClientName";

            /// <summary></summary>
            public const String Description = "Description";

            /// <summary></summary>
            public const String ClientUri = "ClientUri";

            /// <summary></summary>
            public const String LogoUri = "LogoUri";

            /// <summary></summary>
            public const String RequireConsent = "RequireConsent";

            /// <summary></summary>
            public const String AllowRememberConsent = "AllowRememberConsent";

            /// <summary></summary>
            public const String AlwaysIncludeUserClaimsInIdToken = "AlwaysIncludeUserClaimsInIdToken";

            /// <summary></summary>
            public const String RequirePkce = "RequirePkce";

            /// <summary></summary>
            public const String AllowPlainTextPkce = "AllowPlainTextPkce";

            /// <summary></summary>
            public const String AllowAccessTokensViaBrowser = "AllowAccessTokensViaBrowser";

            /// <summary></summary>
            public const String FrontChannelLogoutUri = "FrontChannelLogoutUri";

            /// <summary></summary>
            public const String FrontChannelLogoutSessionRequired = "FrontChannelLogoutSessionRequired";

            /// <summary></summary>
            public const String BackChannelLogoutUri = "BackChannelLogoutUri";

            /// <summary></summary>
            public const String BackChannelLogoutSessionRequired = "BackChannelLogoutSessionRequired";

            /// <summary></summary>
            public const String AllowOfflineAccess = "AllowOfflineAccess";

            /// <summary></summary>
            public const String IdentityTokenLifetime = "IdentityTokenLifetime";

            /// <summary></summary>
            public const String AccessTokenLifetime = "AccessTokenLifetime";

            /// <summary></summary>
            public const String AuthorizationCodeLifetime = "AuthorizationCodeLifetime";

            /// <summary></summary>
            public const String ConsentLifetime = "ConsentLifetime";

            /// <summary></summary>
            public const String AbsoluteRefreshTokenLifetime = "AbsoluteRefreshTokenLifetime";

            /// <summary></summary>
            public const String SlidingRefreshTokenLifetime = "SlidingRefreshTokenLifetime";

            /// <summary></summary>
            public const String RefreshTokenUsage = "RefreshTokenUsage";

            /// <summary></summary>
            public const String UpdateAccessTokenClaimsOnRefresh = "UpdateAccessTokenClaimsOnRefresh";

            /// <summary></summary>
            public const String RefreshTokenExpiration = "RefreshTokenExpiration";

            /// <summary></summary>
            public const String AccessTokenType = "AccessTokenType";

            /// <summary></summary>
            public const String EnableLocalLogin = "EnableLocalLogin";

            /// <summary></summary>
            public const String IncludeJwtId = "IncludeJwtId";

            /// <summary></summary>
            public const String AlwaysSendClientClaims = "AlwaysSendClientClaims";

            /// <summary></summary>
            public const String ClientClaimsPrefix = "ClientClaimsPrefix";

            /// <summary></summary>
            public const String PairWiseSubjectSalt = "PairWiseSubjectSalt";

            /// <summary></summary>
            public const String Created = "Created";

            /// <summary></summary>
            public const String Updated = "Updated";

            /// <summary></summary>
            public const String LastAccessed = "LastAccessed";

            /// <summary></summary>
            public const String UserSsoLifetime = "UserSsoLifetime";

            /// <summary></summary>
            public const String UserCodeType = "UserCodeType";

            /// <summary></summary>
            public const String DeviceCodeLifetime = "DeviceCodeLifetime";

            /// <summary></summary>
            public const String NonEditable = "NonEditable";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IClients
    {
        #region 属性
        /// <summary></summary>
        Int32 Id { get; set; }

        /// <summary></summary>
        Int64 Enabled { get; set; }

        /// <summary></summary>
        String ClientId { get; set; }

        /// <summary></summary>
        String ProtocolType { get; set; }

        /// <summary></summary>
        Int64 RequireClientSecret { get; set; }

        /// <summary></summary>
        String ClientName { get; set; }

        /// <summary></summary>
        String Description { get; set; }

        /// <summary></summary>
        String ClientUri { get; set; }

        /// <summary></summary>
        String LogoUri { get; set; }

        /// <summary></summary>
        Int64 RequireConsent { get; set; }

        /// <summary></summary>
        Int64 AllowRememberConsent { get; set; }

        /// <summary></summary>
        Int64 AlwaysIncludeUserClaimsInIdToken { get; set; }

        /// <summary></summary>
        Int64 RequirePkce { get; set; }

        /// <summary></summary>
        Int64 AllowPlainTextPkce { get; set; }

        /// <summary></summary>
        Int64 AllowAccessTokensViaBrowser { get; set; }

        /// <summary></summary>
        String FrontChannelLogoutUri { get; set; }

        /// <summary></summary>
        Int64 FrontChannelLogoutSessionRequired { get; set; }

        /// <summary></summary>
        String BackChannelLogoutUri { get; set; }

        /// <summary></summary>
        Int64 BackChannelLogoutSessionRequired { get; set; }

        /// <summary></summary>
        Int64 AllowOfflineAccess { get; set; }

        /// <summary></summary>
        Int64 IdentityTokenLifetime { get; set; }

        /// <summary></summary>
        Int64 AccessTokenLifetime { get; set; }

        /// <summary></summary>
        Int64 AuthorizationCodeLifetime { get; set; }

        /// <summary></summary>
        Int64 ConsentLifetime { get; set; }

        /// <summary></summary>
        Int64 AbsoluteRefreshTokenLifetime { get; set; }

        /// <summary></summary>
        Int64 SlidingRefreshTokenLifetime { get; set; }

        /// <summary></summary>
        Int64 RefreshTokenUsage { get; set; }

        /// <summary></summary>
        Int64 UpdateAccessTokenClaimsOnRefresh { get; set; }

        /// <summary></summary>
        Int64 RefreshTokenExpiration { get; set; }

        /// <summary></summary>
        Int64 AccessTokenType { get; set; }

        /// <summary></summary>
        Int64 EnableLocalLogin { get; set; }

        /// <summary></summary>
        Int64 IncludeJwtId { get; set; }

        /// <summary></summary>
        Int64 AlwaysSendClientClaims { get; set; }

        /// <summary></summary>
        String ClientClaimsPrefix { get; set; }

        /// <summary></summary>
        String PairWiseSubjectSalt { get; set; }

        /// <summary></summary>
        String Created { get; set; }

        /// <summary></summary>
        String Updated { get; set; }

        /// <summary></summary>
        String LastAccessed { get; set; }

        /// <summary></summary>
        Int64 UserSsoLifetime { get; set; }

        /// <summary></summary>
        String UserCodeType { get; set; }

        /// <summary></summary>
        Int64 DeviceCodeLifetime { get; set; }

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