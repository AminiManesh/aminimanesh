using Aminimanesh.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aminimanesh.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MessageController : Controller
    {
        private readonly IServiceService _serviceService;
        public MessageController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [Route("messages")]
        public async Task<IActionResult> Index()
        {
            var messages = await _serviceService.GetAllMessages();
            return View(messages);
        }
    }
}
