using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace MiddleWare
{
    public class Program
    {
        public void ConfigureServices (IServiceCollection services)
        {
            services.AddControllers ();
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Other middleware configurations

            // Add the RequestLoggingMiddleware
          
            app.UseMiddleware<RegisterLoggingMiddleware>();
            app.UseStaticFiles();


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers ();
                //endpoints.MapControllerRoute(
                //    name: "products",
                //    pattern: "/products",
                //    defaults: new { controller = "Products", action = "Index" }
                //);

                //endpoints.MapControllerRoute(
                //    name: "productDetails",
                //    pattern: "/products/{id}",
                //    defaults: new { controller = "Products", action = "Details" }
                //);

                //endpoints.MapControllerRoute(
                //    name: "productReviews",
                //    pattern: "/products/{id}/reviews",
                //    defaults: new { controller = "Products", action = "Reviews" }
                //);

                // Other endpoint mappings
            });


            // Other middleware configurations
        }
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}