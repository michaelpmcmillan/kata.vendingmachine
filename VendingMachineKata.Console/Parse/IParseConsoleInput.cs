using VendingMachineKata.Coin;

namespace VendingMachineKata.ConsoleApp.Parse
{
    public interface IParseConsoleInput
    {
        ICoin Parse(string input);
    }
}