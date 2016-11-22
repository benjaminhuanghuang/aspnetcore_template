using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTemplate.Controllers 
{
    public class HomeController : Controller 
    {
        public string Index() 
        {
            return "Hello World, ASP.NET Core Mvc";
        }

        public ViewResult IndexView() 
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
    }
}