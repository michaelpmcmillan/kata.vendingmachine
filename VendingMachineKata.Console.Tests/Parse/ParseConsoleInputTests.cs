using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using FluentAssertions;
using Moq.AutoMock;
using VendingMachineKata.Coin;
using VendingMachineKata.ConsoleApp.Parse;
using Xunit;

namespace VendingMachineKata.Console.Tests.Parse
{
    public class ParseConsoleInputTests
    {
        private Fixture Fixture { get; }
        private AutoMocker Mocker { get; }

        public ParseConsoleInputTests()
        {
            Fixture = new Fixture();
            Mocker = new AutoMocker();
        }

        [Fact]
        public void WhenParseWith5_ThenANickleIsReturned()
        {
            IParseConsoleInput parseConsoleInput = Mocker.CreateInstance<ParseConsoleInput>();

            var coinValue = parseConsoleInput.Parse("5");

            coinValue.Should().Be(5);
        }
    }
}
