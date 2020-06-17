using AutoFixture;
using Moq;
using Moq.AutoMock;
using VendingMachineKata.Coin;
using VendingMachineKata.ConsoleApp;
using VendingMachineKata.ConsoleApp.Parse;
using Xunit;

namespace VendingMachineKata.Console.Tests
{
    public class ConsoleLoopTests
    {
        private Fixture Fixture { get; }
        private AutoMocker Mocker { get; }

        public ConsoleLoopTests()
        {
            Fixture = new Fixture();
            Mocker = new AutoMocker();
        }

        [Fact]
        public void WhenIterate_ThenParseConsoleInputIsInvokedOnce()
        {
            var consoleLoop = Mocker.CreateInstance<ConsoleLoop>();
            var textToParse = Fixture.Create<int>().ToString();

            consoleLoop.Iterate(textToParse);

            Mocker.Verify<IParseConsoleInput, int>(p => p.Parse(textToParse), Times.Once);
        }


        [Fact]
        public void WhenIterate_AndAValidCoinIsInserted_ThenCoinIsParsed()
        {
            var consoleLoop = Mocker.CreateInstance<ConsoleLoop>();
            const int coinValue = 5;
            var textToParse = coinValue.ToString();

            Mocker.GetMock<IParseConsoleInput>()
                .Setup(parseConsoleInput => parseConsoleInput.Parse(textToParse))
                .Returns(coinValue);

            consoleLoop.Iterate(textToParse);

            Mocker.Verify<ICoinFactory>(p => p.Create(coinValue), Times.Once);
        }

        [Fact]
        public void WhenIterate_AndANickelHasBeenDetected_ThenInsertCoinIntoVendingMachine()
        {
            var consoleLoop = Mocker.CreateInstance<ConsoleLoop>();
            ICoin coin = new Nickle();

            Mocker.GetMock<ICoinFactory>()
                .Setup(coinFactory => coinFactory.Create(It.IsAny<int>()))
                .Returns(coin);

            consoleLoop.Iterate("5");

            Mocker.Verify<IVendingMachine>(v => v.InsertCoin(coin));
        }
    }
}
