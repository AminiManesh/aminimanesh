using Microsoft.AspNetCore.Mvc;

namespace Aminimanesh.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("ErrorPage/{statusCode?}")]
        public IActionResult ErrorPage(int? statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewData["Code"] = statusCode;
                    ViewData["Message"] = "صفحه مورد نظر پیدا نشد";
                    break;
                default:
                    break;
            }

            return View();
        }
    }
}
