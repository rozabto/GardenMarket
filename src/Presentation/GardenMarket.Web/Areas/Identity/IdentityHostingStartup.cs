using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(GardenMarket.Web.Areas.Identity.IdentityHostingStartup))]

namespace GardenMarket.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}