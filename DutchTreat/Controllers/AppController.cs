using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController: Controller
    { 

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
                
            }
            else
            {

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
