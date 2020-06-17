using VendingMachineKata.Coin;
using VendingMachineKata.Display;

namespace VendingMachineKata
{
    public class VendingMachine : IVendingMachine
    {
        private readonly ICoinCollection _coinCollection;
        private readonly ICoinFactory _coinFactory;

        public VendingMachine(ICoinCollection coinCollection, ICoinFactory coinFactory)
        {
            _coinCollection = coinCollection;
            _coinFactory = coinFactory;
        }

        public void InsertCoin(CoinEnum coinValue)
        {
            var coin = _coinFactory.Create(coinValue);

            if (coin != null)
            {
                _coinCollection.AddCoin(coin);
            }
        }

        public double GetCoinTotal()
        {
            return _coinCollection.GetCoinTotal();
        }
    }
}