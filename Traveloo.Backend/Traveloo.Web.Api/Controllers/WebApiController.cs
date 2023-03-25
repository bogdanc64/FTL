using Microsoft.AspNetCore.Mvc;
using Traveloo.Api.Core.Controllers;
using Traveloo.Sql.Library.Services;

namespace Traveloo.Web.Api.Controllers
{
    public class WebApiController : WebApiControllerBase
    {
        private readonly ApplicationUserService ApplicationUserService;

        public WebApiController(
            ApplicationUserService applicationUserService
        ) {
            ApplicationUserService = applicationUserService;
        }

        public override async Task<ActionResult<ICollection<ApplicationUser>>> ApplicationUsersGetMany()
        {
            try 
            {
                return ApplicationUserService.GetMany();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

    }
}