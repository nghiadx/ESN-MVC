using CapstoneProject.ESN.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.ESN.Web.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
