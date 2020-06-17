namespace VendingMachineKata.ConsoleApp.Parse
{
    public class ParseConsoleInput : IParseConsoleInput
    {
        public int Parse(string input)
        {
            int.TryParse(input, out var value);
            return value;
        }
    }
}