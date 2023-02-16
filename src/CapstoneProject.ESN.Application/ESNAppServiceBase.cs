using Abp.Application.Services;

namespace CapstoneProject.ESN
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ESNAppServiceBase : ApplicationService
    {
        protected ESNAppServiceBase()
        {
            LocalizationSourceName = ESNConsts.LocalizationSourceName;
        }
    }
}