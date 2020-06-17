﻿using Microsoft.Extensions.DependencyInjection;
using VendingMachineKata.Coin;
using VendingMachineKata.ConsoleApp.Display;
using VendingMachineKata.ConsoleApp.Parse;
using VendingMachineKata.Display;

namespace VendingMachineKata.ConsoleApp.Startup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureIoC(this ServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IConsoleLoop, ConsoleLoop>()
                .AddTransient<IDisplayWriter, ConsoleDisplayWriter>()
                .AddTransient<ICoinFactory, CoinFactory>()
                .AddTransient<ICoinCollection, CoinCollection>()
                .AddTransient<IParseConsoleInput, ParseConsoleInput>()
                .AddTransient<IVendingMachine, VendingMachine>()
                .AddTransient<IVendingMachineDisplay, VendingMachineDisplay>();
        }
    }
}