using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>

           Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(WebHostBuilder =>
           {
               WebHostBuilder.UseStartup<Startup>();
           });
    }
}





