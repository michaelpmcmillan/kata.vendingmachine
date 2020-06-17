using System;
using VendingMachineKata.Coin;

namespace VendingMachineKata.ConsoleApp.Parse
{
    public class ParseConsoleInput : IParseConsoleInput
    {
        public CoinEnum Parse(string input)
        {
            return Enum.Parse<CoinEnum>(input);
        }
    }
}