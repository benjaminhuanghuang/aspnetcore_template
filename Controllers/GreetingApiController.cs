using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreTemplate.Controllers
{
    public class GreetingMessage
    {
        public string Message {get;set;}
    }

    [Route("api/[controller]")]// GET: /<controller>/
    public class GreetingApiController : Controller
    {
        [HttpGet]
        public GreetingMessage Get()
        {
            // return "Hello from ASP.NET core Web API";
            return new GreetingMessage {Message="Hello from ASP.NET core Web API"};
        }
    }
}
