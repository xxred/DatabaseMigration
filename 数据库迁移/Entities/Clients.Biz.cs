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
    public partial class Clients : Entity<Clients>
    {
        #region 对象操作
        static Clients()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.Enabled);

            // 过滤器 UserModule、TimeModule、IPModule
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 这里验证参数范围，建议抛出参数异常，指定参数名，前端用户界面可以捕获参数异常并聚焦到对应的参数输入框
            if (ClientId.IsNullOrEmpty()) throw new ArgumentNullException(nameof(ClientId), "ClientId不能为空！");
            if (ProtocolType.IsNullOrEmpty()) throw new ArgumentNullException(nameof(ProtocolType), "ProtocolType不能为空！");
            if (ClientName.IsNullOrEmpty()) throw new ArgumentNullException(nameof(ClientName), "ClientName不能为空！");
            if (Description.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Description), "Description不能为空！");
            if (ClientUri.IsNullOrEmpty()) throw new ArgumentNullException(nameof(ClientUri), "ClientUri不能为空！");
            if (LogoUri.IsNullOrEmpty()) throw new ArgumentNullException(nameof(LogoUri), "LogoUri不能为空！");
            if (FrontChannelLogoutUri.IsNullOrEmpty()) throw new ArgumentNullException(nameof(FrontChannelLogoutUri), "FrontChannelLogoutUri不能为空！");
            if (BackChannelLogoutUri.IsNullOrEmpty()) throw new ArgumentNullException(nameof(BackChannelLogoutUri), "BackChannelLogoutUri不能为空！");
            if (ClientClaimsPrefix.IsNullOrEmpty()) throw new ArgumentNullException(nameof(ClientClaimsPrefix), "ClientClaimsPrefix不能为空！");
            if (PairWiseSubjectSalt.IsNullOrEmpty()) throw new ArgumentNullException(nameof(PairWiseSubjectSalt), "PairWiseSubjectSalt不能为空！");
            if (Created.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Created), "Created不能为空！");
            if (Updated.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Updated), "Updated不能为空！");
            if (LastAccessed.IsNullOrEmpty()) throw new ArgumentNullException(nameof(LastAccessed), "LastAccessed不能为空！");
            if (UserCodeType.IsNullOrEmpty()) throw new ArgumentNullException(nameof(UserCodeType), "UserCodeType不能为空！");

            // 在新插入数据或者修改了指定字段时进行修正

            // 检查唯一索引
            // CheckExist(isNew, __.ClientId);
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化Clients[Clients]数据……");

        //    var entity = new Clients();
        //    entity.Id = 0;
        //    entity.Enabled = 0;
        //    entity.ClientId = "abc";
        //    entity.ProtocolType = "abc";
        //    entity.RequireClientSecret = 0;
        //    entity.ClientName = "abc";
        //    entity.Description = "abc";
        //    entity.ClientUri = "abc";
        //    entity.LogoUri = "abc";
        //    entity.RequireConsent = 0;
        //    entity.AllowRememberConsent = 0;
        //    entity.AlwaysIncludeUserClaimsInIdToken = 0;
        //    entity.RequirePkce = 0;
        //    entity.AllowPlainTextPkce = 0;
        //    entity.AllowAccessTokensViaBrowser = 0;
        //    entity.FrontChannelLogoutUri = "abc";
        //    entity.FrontChannelLogoutSessionRequired = 0;
        //    entity.BackChannelLogoutUri = "abc";
        //    entity.BackChannelLogoutSessionRequired = 0;
        //    entity.AllowOfflineAccess = 0;
        //    entity.IdentityTokenLifetime = 0;
        //    entity.AccessTokenLifetime = 0;
        //    entity.AuthorizationCodeLifetime = 0;
        //    entity.ConsentLifetime = 0;
        //    entity.AbsoluteRefreshTokenLifetime = 0;
        //    entity.SlidingRefreshTokenLifetime = 0;
        //    entity.RefreshTokenUsage = 0;
        //    entity.UpdateAccessTokenClaimsOnRefresh = 0;
        //    entity.RefreshTokenExpiration = 0;
        //    entity.AccessTokenType = 0;
        //    entity.EnableLocalLogin = 0;
        //    entity.IncludeJwtId = 0;
        //    entity.AlwaysSendClientClaims = 0;
        //    entity.ClientClaimsPrefix = "abc";
        //    entity.PairWiseSubjectSalt = "abc";
        //    entity.Created = "abc";
        //    entity.Updated = "abc";
        //    entity.LastAccessed = "abc";
        //    entity.UserSsoLifetime = 0;
        //    entity.UserCodeType = "abc";
        //    entity.DeviceCodeLifetime = 0;
        //    entity.NonEditable = 0;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化Clients[Clients]数据！");
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
        public static Clients FindById(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.Id == id);

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.Id == id);
        }

        /// <summary>根据ClientId查找</summary>
        /// <param name="clientid">ClientId</param>
        /// <returns>实体对象</returns>
        public static Clients FindByClientId(String clientid)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.ClientId == clientid);

            return Find(_.ClientId == clientid);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}