using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }
        
        public void Configure(IApplicationBuilder app)    
        {
            app.Run(context =>
                {   
                    return context.Response.WriteAsync("Hello from ASP.NET Core!");
                });
        }
    }
}
