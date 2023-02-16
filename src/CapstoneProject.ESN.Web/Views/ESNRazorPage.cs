using Abp.AspNetCore.Mvc.Views;

namespace CapstoneProject.ESN.Web.Views
{
    public abstract class ESNRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ESNRazorPage()
        {
            LocalizationSourceName = ESNConsts.LocalizationSourceName;
        }
    }
}
