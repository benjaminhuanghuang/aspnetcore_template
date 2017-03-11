using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreTemplate
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        // Configure defines the Middleware in the request pipeline
        // In ASP.NET Core you compose your request pipeline using Middleware. 
        // ASP.NET Core middleware performs asynchronous logic on an HttpContext and then either invokes 
        // the next middleware in the sequence or terminates the request directly. 
        public void Configure(IApplicationBuilder app)    
        {
            // asp.net core
            // app.Run(context =>
            //     {   
            //         return context.Response.WriteAsync("Hello from ASP.NET Core!");
            //     });

            // Enable static files like index.html
            app.UseStaticFiles();

            // Enable Cross Origin Resource Sharing
            app.UseCors(builder =>builder.WithOrigins("http://localhost:9000").AllowAnyHeader().AllowAnyMethod());

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        // ConfigureServices defines the services used by app (such as the ASP.NET MVC Core framework, \
        // Entity Framework Core, Identity, etc.)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}
