using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is a Web Application .Net Core to Learning!";
            ViewData["email"] = "eriko@gmail.com";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Privacy Policy";
            ViewData["message_privacy"] = "Use this page to detail your site's privacy policy.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
