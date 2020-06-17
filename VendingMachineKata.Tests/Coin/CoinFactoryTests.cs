using AutoFixture;
using FluentAssertions;
using Moq.AutoMock;
using VendingMachineKata.Coin;
using Xunit;

namespace VendingMachineKata.Tests.Coin
{
    public class CoinFactoryTests
    {
        private Fixture Fixture { get; }
        private AutoMocker Mocker { get; }

        public CoinFactoryTests()
        {
            Fixture = new Fixture();
            Mocker = new AutoMocker();
        }

        [Fact]
        public void WhenCreate_With5Cents_ThenNickleIsCreated()
        {
            const CoinEnum value = CoinEnum.Nickle;
            var coinFactory = Mocker.CreateInstance<CoinFactory>();

            var coin = coinFactory.Create(value);

            coin.Should().BeOfType<Nickle>();
            coin.Value.Should().Be(5);
        }
    }
}
