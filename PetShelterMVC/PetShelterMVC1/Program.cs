using Microsoft.EntityFrameworkCore;
using PetShelter.Data;
using PetShelter.Services;
using PetShelter.Shared.Extensions;
using PetShelterMVC;
using PetShelter.Data.Entities;
using AutoMapper;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();


        builder.Services.AddDbContext<PetShelterDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration["ConnectionStrings:KPNINJA"]);
        });

       

        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie();


        //builder.Services.AddAutoMapper(assemblies: Assembly.GetExecutingAssembly());

        builder.Services.AutoBind(typeof(PetsService).Assembly);
        builder.Services.AutoBind(typeof(PetRepository).Assembly);
        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<PetShelterDbContext>();
            // Automatically update database
            context.Database.Migrate();
        }

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
        app.UseAuthentication();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}