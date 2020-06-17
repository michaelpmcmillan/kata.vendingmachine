using VendingMachineKata.Coin;

namespace VendingMachineKata.ConsoleApp.Parse
{
    public class ParseConsoleInput : IParseConsoleInput
    {
        public ICoin Parse(string input)
        {
            return new Nickle();
        }
    }
}