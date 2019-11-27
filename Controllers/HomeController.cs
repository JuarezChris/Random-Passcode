using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rand_Passcode.Models;
using Microsoft.AspNetCore.Http;


namespace Rand_Passcode.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index(RandomString randstr)
        {
            RandomString callme = new RandomString()
            {
                Passcode = "whatever"
            };
            if (HttpContext.Session.GetInt32("Count") == null)
            {
                HttpContext.Session.SetInt32("Count", 1);
                ViewBag.Count = HttpContext.Session.GetInt32("Count");
                return View(callme);
            }
            else
            {
                int? count = HttpContext.Session.GetInt32("Count") + 1;
                HttpContext.Session.SetInt32("Count", (int)count);
                ViewBag.Count = HttpContext.Session.GetInt32("Count");
                return View(callme);
            }
        }
         [Route("clear")]
        [HttpGet]
        public IActionResult clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }
    }
}
