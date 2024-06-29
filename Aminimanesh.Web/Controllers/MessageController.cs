using Aminimanesh.Core.Services.Interfaces;
using Aminimanesh.DataLayer.Entities.Owner;
using ElectronicLearn.Core.Convertors;
using ElectronicLearn.Core.Senders;
using Microsoft.AspNetCore.Mvc;

namespace Aminimanesh.Web.Controllers
{
    public class MessageController : Controller
    {
        private readonly IViewRenderService _renderView;
        private readonly IOwnerService _ownerService;
        private readonly IServiceService _serviceService;
        public MessageController(IViewRenderService renderView, IOwnerService ownerService, IServiceService serviceService)
        {
            _renderView = renderView;
            _ownerService = ownerService;
            _serviceService = serviceService;
        }

        [HttpPost]
        [Route("send-message")]
        public async Task<IActionResult> SendMessage(Message message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            message.SendDate = DateTime.Now;
            var body = _renderView.RenderToStringAsync("EmailMessage", message);
            SendEmail.Send(await _ownerService.GetIncomeEmailAsync(), $"aminimanesh.ir | Message from {message.SenderEmail}", body);

            await _serviceService.AddMessageAsync(message);

            return new JsonResult(new { success = true, message = "پیام شما با موفقیت ارسال شد." });
        }
    }
}
