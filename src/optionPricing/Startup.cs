using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;

using Microsoft.AspNet.Mvc;
//using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Framework.DependencyInjection;

using Microsoft.Framework.Logging;

//using Microsoft.Extensions.Logging;
using optionPricing.Models;
using Microsoft.Framework.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace optionPricing
{
    public class Startup
    {
        private object servicesEF;

        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public Microsoft.Extensions.Configuration.IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            Microsoft.Framework.DependencyInjection.IServiceCollection serviceEF)
        {
            // Add framework services.
            services.AddMvc();

            services.AddEntityFramework()
           //    .AddSqlServer()
                .AddDbContext<stockContext>();
              

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();

                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private Microsoft.Extensions.Configuration.IConfigurationRoot GetConfiguration()
        {
            return Configuration;
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
