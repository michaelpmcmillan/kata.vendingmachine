using VendingMachineKata.ConsoleApp.Parse;

namespace VendingMachineKata.ConsoleApp
{
    public class ConsoleLoop : IConsoleLoop
    {
        private readonly IParseConsoleInput _parseConsoleInput;

        public ConsoleLoop(IParseConsoleInput parseConsoleInput)
        {
            _parseConsoleInput = parseConsoleInput;
        }

        public void Iterate(string input)
        {
            _parseConsoleInput.Parse(input);
        }
    }
}