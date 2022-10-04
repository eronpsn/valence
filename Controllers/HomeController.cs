using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using Valence.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Valence.WebApp.Models.Login;
using Microsoft.AspNetCore.Authorization;

namespace Valence.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/Home/Index", Name = "AbreHome")]
           [Authorize]
       
        public IActionResult Index()
        {
           /* string email = HttpContext.Session.GetString("Email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToRoute("AbreLogin");
            }
            ViewBag.Email = email;*/
            return View();
        }


 [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Autenticar()
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
