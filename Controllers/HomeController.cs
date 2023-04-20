using Microsoft.AspNetCore.Mvc;

namespace PartyInvites_v2 
{
    public class HomeController : Controller
    {
        public IActionResult index() 
        {
            return View();
        }

        public ViewResult RsvpForm() 
        {
            return View();
        }
    }
}