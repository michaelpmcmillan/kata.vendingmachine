using VendingMachineKata.Coin;
using VendingMachineKata.ConsoleApp.Parse;

namespace VendingMachineKata.ConsoleApp
{
    public class ConsoleLoop : IConsoleLoop
    {
        private readonly IParseConsoleInput _parseConsoleInput;
        private ICoinFactory _coinFactory;

        public ConsoleLoop(IParseConsoleInput parseConsoleInput, ICoinFactory coinFactory)
        {
            _parseConsoleInput = parseConsoleInput;
            _coinFactory = coinFactory;
        }

        public void Iterate(string input)
        {
            var coinValue = _parseConsoleInput.Parse(input);
            var coin = _coinFactory.Create(coinValue);
        }
    }
}