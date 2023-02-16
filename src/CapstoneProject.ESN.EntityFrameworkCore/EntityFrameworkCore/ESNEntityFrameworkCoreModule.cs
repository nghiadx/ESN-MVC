using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CapstoneProject.ESN.EntityFrameworkCore
{
    [DependsOn(
        typeof(ESNCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ESNEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ESNEntityFrameworkCoreModule).GetAssembly());
        }
    }
}