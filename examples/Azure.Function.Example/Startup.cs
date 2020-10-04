using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WaybackMachine.DotNet.Client.Interfaces;
using WaybackMachine.DotNet.Client;

[assembly: FunctionsStartup(typeof(Azure.Function.Example.Startup))]

namespace Azure.Function.Example
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddLogging();

            // Register the wayback machine client for dependency injection
            builder.Services.AddSingleton<IWaybackMachineService, WaybackMachineService>();
        }
    }
}