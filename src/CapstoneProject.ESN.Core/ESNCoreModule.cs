using Abp.Modules;
using Abp.Reflection.Extensions;
using CapstoneProject.ESN.Localization;

namespace CapstoneProject.ESN
{
    public class ESNCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            ESNLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = ESNConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ESNCoreModule).GetAssembly());
        }
    }
}