using eraasoftTask10.Models;
using eraasoftTask10.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eraasoftTask10.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new HomeFormViewModel
            {
                PreferredLanguage = "English",
                Rating = 5
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(HomeFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}