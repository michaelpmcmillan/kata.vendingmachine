using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using VendingMachineKata.Coin;
using Xunit;

namespace VendingMachineKata.Tests
{
    public class VendingMachineTests
    {
        private Fixture Fixture { get; }
        private AutoMocker Mocker { get; }

        public VendingMachineTests()
        {
            Fixture = new Fixture();
            Mocker = new AutoMocker();
        }

        [Fact]
        public void WhenGetCoinTotal_WithANickle_ThenICoinCollectionAddCoinShouldBeInvoked()
        {
            IVendingMachine vendingMachine = Mocker.CreateInstance<VendingMachine>();
            ICoin coin = new Nickle();

            vendingMachine.InsertCoin(coin);

            Mocker.Verify<ICoinCollection>(c => c.AddCoin(coin), Times.Once);
        }

        [Fact]
        public void WhenGetCoinTotal_ThenICoinCollectionGetCoinTotalShouldBeInvoked()
        {
            IVendingMachine vendingMachine = Mocker.CreateInstance<VendingMachine>();

            vendingMachine.GetCoinTotal();

            Mocker.Verify<ICoinCollection, double>(c => c.GetCoinTotal(), Times.Once);
        }
    }
}
