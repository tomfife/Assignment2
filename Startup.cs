using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace thomasSecondWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // This makes sure that we get the error message when there is something wrong with our website
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Add error page here
            }

            app.UseNodeModules();
            app.UseStaticFiles();

            // Turns on generic routing in MVC - we are going to determine which page to go to dynamically
                // Example: amazon.com/giftcards - It knows where to go even though this isn't the url
            app.UseRouting();

            // This determines what we're eventually going to serve to the user
            app.UseEndpoints(cfg =>
            {
                cfg.MapControllerRoute("Default",
                    "{controller}/{action}/{id?}",                     // Look for these in this order... controller - blah, action - index,
                    new {  controller = "Home", action = "Index" });    // Coding by convention. We don't have to say blah controller... it knows
            }
            );
        }
    }
}
