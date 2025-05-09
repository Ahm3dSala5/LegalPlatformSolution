using System.Diagnostics;
using LegalPlatform.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LegalPlatform.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
       
        public IActionResult Lawers()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Community()
        {
            return View();
        }
    }
}
