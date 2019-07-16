using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace GardenMarket.Web
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIIS()
                .UseStartup<Startup>();
    }
}