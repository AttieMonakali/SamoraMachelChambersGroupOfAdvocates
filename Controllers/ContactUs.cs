using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamoraMachelChambersGroupOfAdvocates.Service;
using SamoraMachelChambersGroupOfAdvocates.Models;

namespace SamoraMachelChambersGroupOfAdvocates.Controllers
{
    public class ContactUs : Controller
    {
        //private readonly TestContext _context;
        private readonly IMailService _mailService;

        //public ContactUs(IMailService mailService, TestContext testContext)
        //{
        //    _mailService = mailService;
        //    _context = testContext;

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
        public IActionResult Create(ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                // Send the email
                //_mailService.SendMessage("reception@samoramachelchambers.com", $": {contactUs.Subject}", $"From: {contactUs.Name} - {contactUs.Email}, Message: {contactU.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            return View();
        }
    }
}
