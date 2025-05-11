using Microsoft.AspNetCore.Mvc;

namespace LegalPlatform.API.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult OpenPage()
        {
            return View();
        }
    }

   
}
