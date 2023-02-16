using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.ESN.Web.Controllers
{
    public class HomeController : ESNControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}