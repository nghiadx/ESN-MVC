using Abp.Web.Models;
using CapstoneProject.ESN.Models;
using CapstoneProject.ESN.Users;
using CapstoneProject.ESN.Web.Models.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CapstoneProject.ESN.Web.Controllers
{
    public class UsersController : ESNControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> Login()
        {
            return View();
        }

        //[HttpPost]
        //public virtual async Task<JsonResult> Login(LoginViewModel loginModel, string returnUrl = "", string returnUrlHash = "")
        //{
        //    if (!string.IsNullOrWhiteSpace(returnUrlHash))
        //    {
        //        returnUrl = returnUrl + returnUrlHash;
        //    }

        //    //var loginResult = await GetLoginResultAsync(loginMo, tenancyNamedel.UsernameOrEmailAddress, loginModel.Password);
        //    User user = await _userAppService.LoginAsync(loginModel.UsernameOrEmailAddress, loginModel.Password);

        //    return Json(new AjaxResponse { TargetUrl = returnUrl });
        //}

        [HttpPost]
        public virtual async Task<string> Login(LoginViewModel loginModel, string returnUrl = "", string returnUrlHash = "")
        {
            if (!string.IsNullOrWhiteSpace(returnUrlHash))
            {
                returnUrl = returnUrl + returnUrlHash;
            }

            //var loginResult = await GetLoginResultAsync(loginMo, tenancyNamedel.UsernameOrEmailAddress, loginModel.Password);
            User user = await _userAppService.LoginAsync(loginModel.UsernameOrEmailAddress, loginModel.Password);

            if(user != null)
            {
                return "Login successfuly";
            }
            else
            {
                return "Login fail";
            }
            
        }

    }
}
