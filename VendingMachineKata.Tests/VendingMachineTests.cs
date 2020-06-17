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
        public void WhenInsertCoin_WithANickle_ICoinFactoryCreateShouldBeInvoked()
        {
            IVendingMachine vendingMachine = Mocker.CreateInstance<VendingMachine>();
            const CoinEnum coin = CoinEnum.Nickle;

            vendingMachine.InsertCoin(coin);

            Mocker.Verify<ICoinFactory>(c => c.Create(coin), Times.Once);
        }

        [Fact]
        public void WhenInsertCoin_WithANickle_ICoinCollectionAddCoinShouldBeInvoked()
        {
            IVendingMachine vendingMachine = Mocker.CreateInstance<VendingMachine>();
            const CoinEnum coin = CoinEnum.Nickle;
            var nickle = new Nickle();

            Mocker.GetMock<ICoinFactory>().Setup(c => c.Create(coin)).Returns(nickle);

            vendingMachine.InsertCoin(coin);

            Mocker.Verify<ICoinCollection>(c => c.AddCoin(nickle), Times.Once);
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
