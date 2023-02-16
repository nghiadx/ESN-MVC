using Abp.AspNetCore.Mvc.Controllers;

namespace CapstoneProject.ESN.Web.Controllers
{
    public abstract class ESNControllerBase: AbpController
    {
        protected ESNControllerBase()
        {
            LocalizationSourceName = ESNConsts.LocalizationSourceName;
        }
    }
}