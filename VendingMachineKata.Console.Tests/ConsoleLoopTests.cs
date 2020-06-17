using AutoFixture;
using Moq;
using Moq.AutoMock;
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

            Mocker.Verify<IParseConsoleInput>(p => p.Parse(textToParse), Times.Once);
        }
    }
}
