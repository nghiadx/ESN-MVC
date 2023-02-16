using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CapstoneProject.ESN.Web.Startup;
namespace CapstoneProject.ESN.Web.Tests
{
    [DependsOn(
        typeof(ESNWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class ESNWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ESNWebTestModule).GetAssembly());
        }
    }
}