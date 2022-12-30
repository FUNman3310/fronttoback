using FrontToAdd.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToAdd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer("Server=JOJO;Database=FrontToBack;Trusted_Connection=True");
            });



            var app = builder.Build();
            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}/{id?}"
                );

            app.UseRouting();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.Run();
        }
    }
}