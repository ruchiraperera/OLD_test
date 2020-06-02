using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace startup_file_configuration
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //register services....
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //exception handler page
                app.UseExceptionHandler("/error.html");
            }

            app.UseRouting();
            
            //--------------------------------------------- File Browsing -------------------
            app.UseDefaultFiles(); //this should be called before UseStaticFiles

            //DefaultFilesOptions options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
            //options.DefaultFileNames.Add("mydefault.html");
            //app.UseDefaultFiles(options);

                                 
            app.UseStaticFiles();
            app.UseDirectoryBrowser();

            //app.UseFileServer(); // this includes all three. (UseDefaultFiles, UseStaticFiles, UseDirectoryBrowser)

            //app.UseFileServer();

            //app.UseFileServer(new FileServerOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //        Path.Combine(Directory.GetCurrentDirectory(), @"MyStaticFiles")),
            //    RequestPath = new PathString("/StaticFiles"),
            //    EnableDirectoryBrowsing = true
            //});

            //OR
            //app.UseFileServer(enableDirectoryBrowsing: true);

            //If enableDirectoryBrowsing is set to true you are required to call AddDirectoryBrowser 
            //extension method from Startup.ConfigureServices:

            //--------------------------------------------- File Browsing -------------------


            // ---------------------------------- what is the different between app.use and app.run ------------------------
            // this will help to attached any number of response to the result.
            //app.Use may call next middleware component in the pipeline. On the other hand, middlware defined 
            //using app.Run will never call subsequent middleware. Let’s see via code.
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Render in the page");
            //    await next();
            //});

            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("this text will be rendered in the page");
            //});

            // ---------------------------------- what is the different between app.use and app.run ------------------------


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
