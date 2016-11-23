using System;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTemplate.Models;

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

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }
        
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}