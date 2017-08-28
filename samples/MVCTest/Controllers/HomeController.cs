using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using swagger;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyAPI _api;

        public HomeController(IMyAPI api)
        {
            _api = api;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _api.ApiValuesGetAsync();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
