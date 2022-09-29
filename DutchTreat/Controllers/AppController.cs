using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController: Controller
    {
        private IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            
            return View(); //represents RAZER 
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            
            
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("lucy@lucy.com", model.Subject,  model.Message);
                ViewBag.UserMessage = "Mail sent!";
                ModelState.Clear();
                
            }
           
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }
    }

}
