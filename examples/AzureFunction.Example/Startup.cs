using Microsoft.Extensions.DependencyInjection;
using WaybackMachine.DotNet.Client.Interfaces;
using WaybackMachine.DotNet.Client;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunction.Example.Startup))]

namespace AzureFunction.Example
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging();

            // Register the wayback machine client
            builder.Services.AddSingleton<IWaybackMachineService, WaybackMachineService>();
        }
    }
}