using Laboratorium_3.Models.Memory;
using Laboratorium_3.Models;
using Laboratorium_3.Models.Memory.Laboratorium_3.Models.Memory;
using Laboratorium_3.Models.EF;
using Microsoft.AspNetCore.Identity;

namespace Laboratorium_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IContactService, MemoryContactService>();
            builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProvider>();
            builder.Services.AddSingleton<IEmployeeService, EmployeeService>();

            builder.Services.AddDbContext<Data.AppDbContext>();
            builder.Services.AddTransient<IContactService, EFContactService>();

            builder.Services.AddDbContext<EmployeeData.EmployeeDbContext>();
            builder.Services.AddTransient<IEmployeeService, EFEmployeeService>();

            builder.Services.AddDefaultIdentity<IdentityUser>()       // dodaæ
    .AddEntityFrameworkStores<Data.AppDbContext>();
            builder.Services.AddMemoryCache();                        // dodaæ
            builder.Services.AddSession();                            // dodaæ   


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

            app.UseAuthentication();                                 // dodaæ
            app.UseAuthorization();                                  // dodaæ
            app.UseSession();                                        // dodaæ 
            app.MapRazorPages();                                     // dodaæ

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}