using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItsUmbria2020.WebApp.FrontEnd.Models;

namespace ItsUmbria2020.WebApp.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string path = @"C:\Users\a.albini\Documents\Github\ItsUmbria2020\ItsUmbria2020.WebApp.FrontEnd\Articles\";
        private static List<Page> pages = new List<Page>()
        {
            new Page(){ Name="Html", Menu="HtmlMenu" },
            new Page(){ Name="Css", Menu="CssMenu" },
            new Page(){ Name="Javascript", Menu="JavascriptMenu" },
            new Page(){ Name="JQuery", Menu="JQueryMenu" }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Html()
        {
            return View("_Page", pages.FirstOrDefault(x => x.Name == "Html"));
        }
        public IActionResult Css()
        {
            return View("_Page", pages.FirstOrDefault(x => x.Name == "Css"));
        }
        public IActionResult Javascript()
        {
            return View("_Page", pages.FirstOrDefault(x => x.Name == "Javascript"));
        }
        public IActionResult JQuery()
        {
            return View("_Page", pages.FirstOrDefault(x => x.Name == "JQuery"));
        }

        [HttpGet]
        public IActionResult GetPage(string name)
        {
            return PartialView("Views/Articles/" + name.Replace(".html", ".cshtml"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
