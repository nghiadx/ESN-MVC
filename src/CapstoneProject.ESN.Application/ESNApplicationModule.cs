using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CapstoneProject.ESN
{
    [DependsOn(
        typeof(ESNCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ESNApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ESNApplicationModule).GetAssembly());
        }
    }
}