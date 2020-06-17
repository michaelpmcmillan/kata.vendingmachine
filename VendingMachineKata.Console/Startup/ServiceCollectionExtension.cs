using Microsoft.Extensions.DependencyInjection;
using VendingMachineKata.ConsoleApp.Parse;

namespace VendingMachineKata.ConsoleApp.Startup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureIoC(this ServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IConsoleLoop, ConsoleLoop>()
                .AddTransient<IParseConsoleInput, ParseConsoleInput>();
        }
    }
}