using Microsoft.Extensions.DependencyInjection;
using VendingMachineKata.Coin;
using VendingMachineKata.ConsoleApp.Parse;

namespace VendingMachineKata.ConsoleApp.Startup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureIoC(this ServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IConsoleLoop, ConsoleLoop>()
                .AddTransient<ICoinFactory, CoinFactory>()
                .AddTransient<IParseConsoleInput, ParseConsoleInput>()
                .AddTransient<IVendingMachine, VendingMachine>();
        }
    }
}