using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Tests.Setup
{
    public class LISWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseStartup<TStartup>()
                        .UseTestServer()
                        .ConfigureAppConfiguration(conf => conf.AddJsonFile("appsettings.json", optional: false).AddEnvironmentVariables())
                        .ConfigureTestServices(services => services.AddMvc().AddApplicationPart(typeof(TStartup).Assembly));
                });

            return builder;
        }
    }
}
