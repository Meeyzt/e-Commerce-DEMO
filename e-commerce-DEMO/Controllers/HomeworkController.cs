using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_DEMO.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Example1()
        {
            TempData["welcomeMessage"] ="Kanalıma Hoşgeldiniz Abone olmayı unutmayın.";
            TempData["subsCount"] = 200.000;
            TempData["buttonName"] = "Abone Ol";
            TempData["buttonColor"] = "#b40505";
            return View();
        }
        public IActionResult Example2()
        {
            ViewBag.welcomeMessage = "Kanalıma Hoşgeldiniz Abone olmayı unutmayın.";
            ViewBag.subsCount = 200.000;
            ViewBag.buttonName = "Abone Ol";
            ViewBag.buttonColor = "#b40505";
            return View();
        }
        public IActionResult Example3()
        {
            ViewData["welcomeMessage"] = "Kanalıma Hoşgeldiniz Abone olmayı unutmayın.";
            ViewData["subsCount"] = 200.000;
            ViewData["buttonName"] = "Abone Ol";
            ViewData["buttonColor"] = "#b40505";
            return View();
        }
    }
}
