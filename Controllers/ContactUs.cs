using MailKit;
using Microsoft.AspNetCore.Mvc;
using SamoraMachelAPI.Model;

namespace SamoraMachelChambersGroupOfAdvocates.Controllers
{
    public class ContactUs : Controller
    {

        private readonly IMailService _mailService;

        //public ContactUs(IMailService mailService)
        //{
        //    _mailService = mailService;

        //}

        // GET: ContactUs
        public async Task<IActionResult> Index()
        {
            return View();
        }


        [HttpGet("contactUs")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("contactUs")]
        public IActionResult Create(ContactU contactU)
        {
            if (ModelState.IsValid)
            {
                // Send the email
                //_mailService.SendEmailAsync("reception@samoramachelchambers.com", $": {contactU.Subject}", $"From: {contactU.Name} - {contactU.Email}, Message: {contactU.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            return View();
        }
    }
}
