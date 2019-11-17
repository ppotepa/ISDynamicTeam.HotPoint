using ISDynamicTeam.HotPoint.WebAPI.Controllers;
using ISDynamicTeam.HotPoint.WebAPI.Routers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ISDynamicTeam.HotPoint.WebAPI
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            CommandController.InitializeRouter();
            CreateWebHostBuilder(args).Build().Run();
        }
       
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
