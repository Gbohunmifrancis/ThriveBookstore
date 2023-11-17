using BookstoreMVC.Data;
using BookstoreMVC.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.Configure<IISServerOptions>(options =>
        {
            options.MaxRequestBodySize = 104857600; // 100MB
        });

    

        services.AddDbContext<BookStoreContext>(
            Options => Options.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;"));
        services.AddControllersWithViews();
#if DEBUG
        // services.AddRazorPages().AddRazorRuntimeCompilation().AddViewOptions(option =>
        // {
        //     option.HtmlHelperOptions.ClientValidationEnabled = false;
        // });
        

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

