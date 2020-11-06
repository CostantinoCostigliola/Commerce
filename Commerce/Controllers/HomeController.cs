using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.EntityClient;
using System.Data;
using System.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Commerce.Helpers;

namespace Commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NOCOMMERCEContext _context;
        public HomeController(ILogger<HomeController> logger, NOCOMMERCEContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Customer loggedUser = new Customer();
            loggedUser = TempData.Get<Customer>("UserLogged");
            ViewData["Name"] = loggedUser.Name;
            return View();
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
