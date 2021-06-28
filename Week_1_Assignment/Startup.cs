using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_1_Assignment.Models;

namespace Week_1_Assignment
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();// ACtivate all the object or service require to understand ctrl and views

            services.AddScoped<IUser, UserData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Built In Middleware 
            // Serve  Static Files
            app.UseStaticFiles(); // Understand  wwwroot
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Default URL :   http://localhost/home/details/1
                endpoints.MapDefaultControllerRoute(); // routing  ..

            });
        }
    }
}
