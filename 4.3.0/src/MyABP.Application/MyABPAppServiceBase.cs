using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using MyABP.Authorization.Users;
using MyABP.MultiTenancy;
using MyABP.Users;
using Microsoft.AspNet.Identity;

namespace MyABP
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyABPAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        /// <summary>
        /// 基类，在该基类中的构造函数中定义LocalizationSourceName。
        /// 这样，就不用为所有的服务类重复定义了。
        /// </summary>
        protected MyABPAppServiceBase()
        {
            LocalizationSourceName = MyABPConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}