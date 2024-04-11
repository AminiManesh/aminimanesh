using Aminimanesh.Core.DTOs.MessageDTOs;
using Aminimanesh.Core.Services.Interfaces;
using ElectronicLearn.Core.Convertors;
using ElectronicLearn.Core.Senders;
using Microsoft.AspNetCore.Mvc;

namespace Aminimanesh.Web.Controllers
{
    public class MessageController : Controller
    {
        private readonly IViewRenderService _renderView;
        private readonly IOwnerService _ownerService;
        public MessageController(IViewRenderService renderView, IOwnerService ownerService)
        {
            _renderView = renderView;
            _ownerService = ownerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SendMessage(CreateMessageDTO message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            var body = _renderView.RenderToStringAsync("EmailMessage", message);
            SendEmail.Send(await _ownerService.GetIncomeEmailAsync(), $"aminimanesh.ir | Message from {message.SenderEmail}", body);

            return new JsonResult(new { success = true, message = "پیام شما با موفقیت ارسال شد!" });
        }
    }
}
