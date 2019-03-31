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
    [BindIndex("IX_AuditEntries_When", false, "When")]
    [BindTable("AuditEntries", Description = "", ConnName = "identityServer_sqlite", DbType = DatabaseType.SQLite)]
    public partial class AuditEntries : IAuditEntries
    {
        #region 属性
        private Int32 _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "", "INTEGER")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _When;
        /// <summary></summary>
        [DisplayName("When")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("When", "", "TEXT")]
        public String When { get { return _When; } set { if (OnPropertyChanging(__.When, value)) { _When = value; OnPropertyChanged(__.When); } } }

        private String _Source;
        /// <summary></summary>
        [DisplayName("Source")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Source", "", "TEXT")]
        public String Source { get { return _Source; } set { if (OnPropertyChanging(__.Source, value)) { _Source = value; OnPropertyChanged(__.Source); } } }

        private String _SubjectType;
        /// <summary></summary>
        [DisplayName("SubjectType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SubjectType", "", "TEXT")]
        public String SubjectType { get { return _SubjectType; } set { if (OnPropertyChanging(__.SubjectType, value)) { _SubjectType = value; OnPropertyChanged(__.SubjectType); } } }

        private String _SubjectIdentifier;
        /// <summary></summary>
        [DisplayName("SubjectIdentifier")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SubjectIdentifier", "", "TEXT")]
        public String SubjectIdentifier { get { return _SubjectIdentifier; } set { if (OnPropertyChanging(__.SubjectIdentifier, value)) { _SubjectIdentifier = value; OnPropertyChanged(__.SubjectIdentifier); } } }

        private String _Subject;
        /// <summary></summary>
        [DisplayName("Subject")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Subject", "", "TEXT")]
        public String Subject { get { return _Subject; } set { if (OnPropertyChanging(__.Subject, value)) { _Subject = value; OnPropertyChanged(__.Subject); } } }

        private String _Action;
        /// <summary></summary>
        [DisplayName("Action")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Action", "", "TEXT")]
        public String Action { get { return _Action; } set { if (OnPropertyChanging(__.Action, value)) { _Action = value; OnPropertyChanged(__.Action); } } }

        private String _ResourceType;
        /// <summary></summary>
        [DisplayName("ResourceType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ResourceType", "", "TEXT")]
        public String ResourceType { get { return _ResourceType; } set { if (OnPropertyChanging(__.ResourceType, value)) { _ResourceType = value; OnPropertyChanged(__.ResourceType); } } }

        private String _Resource;
        /// <summary></summary>
        [DisplayName("Resource")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Resource", "", "TEXT")]
        public String Resource { get { return _Resource; } set { if (OnPropertyChanging(__.Resource, value)) { _Resource = value; OnPropertyChanged(__.Resource); } } }

        private String _ResourceIdentifier;
        /// <summary></summary>
        [DisplayName("ResourceIdentifier")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ResourceIdentifier", "", "TEXT")]
        public String ResourceIdentifier { get { return _ResourceIdentifier; } set { if (OnPropertyChanging(__.ResourceIdentifier, value)) { _ResourceIdentifier = value; OnPropertyChanged(__.ResourceIdentifier); } } }

        private Int64 _Succeeded;
        /// <summary></summary>
        [DisplayName("Succeeded")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Succeeded", "", "INTEGER")]
        public Int64 Succeeded { get { return _Succeeded; } set { if (OnPropertyChanging(__.Succeeded, value)) { _Succeeded = value; OnPropertyChanged(__.Succeeded); } } }

        private String _Description;
        /// <summary></summary>
        [DisplayName("Description")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Description", "", "TEXT")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }

        private String _NormalisedSubject;
        /// <summary></summary>
        [DisplayName("NormalisedSubject")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalisedSubject", "", "TEXT")]
        public String NormalisedSubject { get { return _NormalisedSubject; } set { if (OnPropertyChanging(__.NormalisedSubject, value)) { _NormalisedSubject = value; OnPropertyChanged(__.NormalisedSubject); } } }

        private String _NormalisedAction;
        /// <summary></summary>
        [DisplayName("NormalisedAction")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalisedAction", "", "TEXT")]
        public String NormalisedAction { get { return _NormalisedAction; } set { if (OnPropertyChanging(__.NormalisedAction, value)) { _NormalisedAction = value; OnPropertyChanged(__.NormalisedAction); } } }

        private String _NormalisedResource;
        /// <summary></summary>
        [DisplayName("NormalisedResource")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalisedResource", "", "TEXT")]
        public String NormalisedResource { get { return _NormalisedResource; } set { if (OnPropertyChanging(__.NormalisedResource, value)) { _NormalisedResource = value; OnPropertyChanged(__.NormalisedResource); } } }

        private String _NormalisedSource;
        /// <summary></summary>
        [DisplayName("NormalisedSource")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NormalisedSource", "", "TEXT")]
        public String NormalisedSource { get { return _NormalisedSource; } set { if (OnPropertyChanging(__.NormalisedSource, value)) { _NormalisedSource = value; OnPropertyChanged(__.NormalisedSource); } } }
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
                    case __.When : return _When;
                    case __.Source : return _Source;
                    case __.SubjectType : return _SubjectType;
                    case __.SubjectIdentifier : return _SubjectIdentifier;
                    case __.Subject : return _Subject;
                    case __.Action : return _Action;
                    case __.ResourceType : return _ResourceType;
                    case __.Resource : return _Resource;
                    case __.ResourceIdentifier : return _ResourceIdentifier;
                    case __.Succeeded : return _Succeeded;
                    case __.Description : return _Description;
                    case __.NormalisedSubject : return _NormalisedSubject;
                    case __.NormalisedAction : return _NormalisedAction;
                    case __.NormalisedResource : return _NormalisedResource;
                    case __.NormalisedSource : return _NormalisedSource;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = value.ToInt(); break;
                    case __.When : _When = Convert.ToString(value); break;
                    case __.Source : _Source = Convert.ToString(value); break;
                    case __.SubjectType : _SubjectType = Convert.ToString(value); break;
                    case __.SubjectIdentifier : _SubjectIdentifier = Convert.ToString(value); break;
                    case __.Subject : _Subject = Convert.ToString(value); break;
                    case __.Action : _Action = Convert.ToString(value); break;
                    case __.ResourceType : _ResourceType = Convert.ToString(value); break;
                    case __.Resource : _Resource = Convert.ToString(value); break;
                    case __.ResourceIdentifier : _ResourceIdentifier = Convert.ToString(value); break;
                    case __.Succeeded : _Succeeded = value.ToLong(); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.NormalisedSubject : _NormalisedSubject = Convert.ToString(value); break;
                    case __.NormalisedAction : _NormalisedAction = Convert.ToString(value); break;
                    case __.NormalisedResource : _NormalisedResource = Convert.ToString(value); break;
                    case __.NormalisedSource : _NormalisedSource = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得AuditEntries字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary></summary>
            public static readonly Field When = FindByName(__.When);

            /// <summary></summary>
            public static readonly Field Source = FindByName(__.Source);

            /// <summary></summary>
            public static readonly Field SubjectType = FindByName(__.SubjectType);

            /// <summary></summary>
            public static readonly Field SubjectIdentifier = FindByName(__.SubjectIdentifier);

            /// <summary></summary>
            public static readonly Field Subject = FindByName(__.Subject);

            /// <summary></summary>
            public static readonly Field Action = FindByName(__.Action);

            /// <summary></summary>
            public static readonly Field ResourceType = FindByName(__.ResourceType);

            /// <summary></summary>
            public static readonly Field Resource = FindByName(__.Resource);

            /// <summary></summary>
            public static readonly Field ResourceIdentifier = FindByName(__.ResourceIdentifier);

            /// <summary></summary>
            public static readonly Field Succeeded = FindByName(__.Succeeded);

            /// <summary></summary>
            public static readonly Field Description = FindByName(__.Description);

            /// <summary></summary>
            public static readonly Field NormalisedSubject = FindByName(__.NormalisedSubject);

            /// <summary></summary>
            public static readonly Field NormalisedAction = FindByName(__.NormalisedAction);

            /// <summary></summary>
            public static readonly Field NormalisedResource = FindByName(__.NormalisedResource);

            /// <summary></summary>
            public static readonly Field NormalisedSource = FindByName(__.NormalisedSource);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得AuditEntries字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Id = "Id";

            /// <summary></summary>
            public const String When = "When";

            /// <summary></summary>
            public const String Source = "Source";

            /// <summary></summary>
            public const String SubjectType = "SubjectType";

            /// <summary></summary>
            public const String SubjectIdentifier = "SubjectIdentifier";

            /// <summary></summary>
            public const String Subject = "Subject";

            /// <summary></summary>
            public const String Action = "Action";

            /// <summary></summary>
            public const String ResourceType = "ResourceType";

            /// <summary></summary>
            public const String Resource = "Resource";

            /// <summary></summary>
            public const String ResourceIdentifier = "ResourceIdentifier";

            /// <summary></summary>
            public const String Succeeded = "Succeeded";

            /// <summary></summary>
            public const String Description = "Description";

            /// <summary></summary>
            public const String NormalisedSubject = "NormalisedSubject";

            /// <summary></summary>
            public const String NormalisedAction = "NormalisedAction";

            /// <summary></summary>
            public const String NormalisedResource = "NormalisedResource";

            /// <summary></summary>
            public const String NormalisedSource = "NormalisedSource";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IAuditEntries
    {
        #region 属性
        /// <summary></summary>
        Int32 Id { get; set; }

        /// <summary></summary>
        String When { get; set; }

        /// <summary></summary>
        String Source { get; set; }

        /// <summary></summary>
        String SubjectType { get; set; }

        /// <summary></summary>
        String SubjectIdentifier { get; set; }

        /// <summary></summary>
        String Subject { get; set; }

        /// <summary></summary>
        String Action { get; set; }

        /// <summary></summary>
        String ResourceType { get; set; }

        /// <summary></summary>
        String Resource { get; set; }

        /// <summary></summary>
        String ResourceIdentifier { get; set; }

        /// <summary></summary>
        Int64 Succeeded { get; set; }

        /// <summary></summary>
        String Description { get; set; }

        /// <summary></summary>
        String NormalisedSubject { get; set; }

        /// <summary></summary>
        String NormalisedAction { get; set; }

        /// <summary></summary>
        String NormalisedResource { get; set; }

        /// <summary></summary>
        String NormalisedSource { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}