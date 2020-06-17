using System;
using AutoFixture;
using Moq.AutoMock;
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
        public void Given_When_Then()
        {
            
        }
    }
}
