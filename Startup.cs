using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ode2Food.Models;
using ode2Food.Services;

namespace ode2Food
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddSingleton<IResturant, InMemoryResturant>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IGreeter greeter, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.UseFileServer();
            //app.UseMvcWithDefaultRoute();

            app.UseMvc();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Use(next =>
           {
               return async context =>
               {
                   logger.LogInformation("Incomming Request");
                   if (context.Request.Path.StartsWithSegments("/mym"))
                   {
                       await context.Response.WriteAsync("middleware hit");
                       logger.LogInformation("Handeled");

                   }
                   else
                   {
                       await next(context);
                       logger.LogInformation("Response out going");

                   }

               };
           });

            app.UseWelcomePage(new WelcomePageOptions
            {
                Path = "/welcome"
            });

            app.Run(async context =>
               {
                   //throw new Exception("Error");
                   //var greeting = $"{greeter.greetingsOfTheDay()} in {env.EnvironmentName}";
                   context.Response.ContentType = "text/plain";
                   await context.Response.WriteAsync("Not Found!");
               });
        }


    }
}
