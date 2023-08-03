namespace ProductsWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Product product = new Product();
            product.Id = 1;
            product.Name = "Example Product";
            product.Price = 10.99m;

            Console.WriteLine("Product ID: " + product.Id);
            Console.WriteLine("Product Name: " + product.Name);
            Console.WriteLine("Product Price: " + product.Price);

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}