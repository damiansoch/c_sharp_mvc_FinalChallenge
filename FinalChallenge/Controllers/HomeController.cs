using FinalChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge.Controllers
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
        public IActionResult Date()
        {
            DateTime now = DateTime.Now;
            return View(now);
        }

        public IActionResult E_Handler()
        {
            return View();
        }
        public IActionResult Razor_Handler()
        {
            return View();
        }
        public IActionResult VoidM()
        {
            return View();
        }
        //----------------------------------------------------------------

        public IActionResult ClickHandler()
        {
            string clicked = "You Clicked the button";
            return View("E_Handler", clicked);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
