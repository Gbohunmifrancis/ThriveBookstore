using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;
using BookstoreMVC.Data;
using BookstoreMVC.Repository;


public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<BookStoreContext>(
            Options => Options.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;"));
        services.AddControllersWithViews();
#if DEBUG
        services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        services.AddScoped<BookRepository, BookRepository>();
    }







    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      
       
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
            
        });

            
        


    }
}


