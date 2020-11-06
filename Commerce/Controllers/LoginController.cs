using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commerce.Helpers;
using Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Commerce.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly NOCOMMERCEContext _context;
        public LoginController(ILogger<LoginController> logger, NOCOMMERCEContext context)
        {
            _logger = logger;
            _context = context;

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Customer objUser)
        {
            if (ModelState.IsValid)
            {
                var userLogged = _context.Customer
                .Where(b => b.Username == objUser.Username && b.Password == objUser.Password)
                .FirstOrDefault();
                if (userLogged != null)
                {
                    TempData.Put("UserLogged", userLogged);

                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    return RedirectToAction("Error", "Home");
                }
            }
            return View("Error");
        }

        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(Customer objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var userLogged = _context.Customer
        //        .Where(b => b.Username == objUser.Username && b.Password == objUser.Password)
        //        .FirstOrDefault();
        //        if (userLogged != null)
        //        {
        //            TempData.Put("UserLogged", userLogged);

        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {

        //            return RedirectToAction("Error", "Home");
        //        }
        //    }
        //    return View("Error");
        //}


    }
}
