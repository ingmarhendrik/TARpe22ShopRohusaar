using Microsoft.AspNetCore.Mvc;
using TARpe22ShopRohusaar.Core.Dto;
using TARpe22ShopRohusaar.Core.ServiceInterface;
using TARpe22ShopRohusaar.Models.Email;

namespace TARpe22ShopRohusaar.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendEmail(EmailViewModel vm)
        {
            var dto = new EmailDto()
            {
                To = vm.To,
                Subject = vm.Subject,
                Body = vm.Body,
            };

            _emailService.SendEmail(dto);
            return RedirectToAction(nameof(Index));
        }
    }
}
