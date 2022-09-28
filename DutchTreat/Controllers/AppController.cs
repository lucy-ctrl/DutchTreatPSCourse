using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController: Controller
    { 

        public IActionResult Index()
        {
            throw new InvalidProgramException("bad things happen to good devs");
            return View(); //represents RAZER 
        }
    }
}
