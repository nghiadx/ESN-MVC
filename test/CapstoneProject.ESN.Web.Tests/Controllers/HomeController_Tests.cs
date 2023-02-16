using System.Threading.Tasks;
using CapstoneProject.ESN.Web.Controllers;
using Shouldly;
using Xunit;

namespace CapstoneProject.ESN.Web.Tests.Controllers
{
    public class HomeController_Tests: ESNWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
