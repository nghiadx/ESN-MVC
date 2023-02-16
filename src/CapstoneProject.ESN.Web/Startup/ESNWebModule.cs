using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CapstoneProject.ESN.Configuration;
using CapstoneProject.ESN.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace CapstoneProject.ESN.Web.Startup
{
    [DependsOn(
        typeof(ESNApplicationModule), 
        typeof(ESNEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class ESNWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ESNWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ESNConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<ESNNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ESNApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ESNWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ESNWebModule).Assembly);
        }
    }
}
