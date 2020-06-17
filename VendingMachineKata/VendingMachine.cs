using VendingMachineKata.Coin;
using VendingMachineKata.Display;

namespace VendingMachineKata
{
    public class VendingMachine : IVendingMachine
    {
        private readonly ICoinCollection _coinCollection;
        private readonly ICoinFactory _coinFactory;
        private readonly IVendingMachineDisplay _vendingMachineDisplay;

        public VendingMachine(ICoinCollection coinCollection, ICoinFactory coinFactory, IVendingMachineDisplay vendingMachineDisplay)
        {
            _coinCollection = coinCollection;
            _coinFactory = coinFactory;
            _vendingMachineDisplay = vendingMachineDisplay;
        }

        public void InsertCoin(CoinEnum coinValue)
        {
            var coin = _coinFactory.Create(coinValue);

            if (coin != null)
            {
                _coinCollection.AddCoin(coin);
                _vendingMachineDisplay.Update(_coinCollection);
            }
        }

        public double GetCoinTotal()
        {
            return _coinCollection.GetCoinTotal();
        }
    }
}