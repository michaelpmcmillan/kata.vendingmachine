using VendingMachineKata.Coin;

namespace VendingMachineKata
{
    public class VendingMachine : IVendingMachine
    {
        private readonly ICoinCollection _coinCollection;

        public VendingMachine(ICoinCollection coinCollection)
        {
            _coinCollection = coinCollection;
        }

        public void InsertCoin(ICoin coin)
        {
            _coinCollection.AddCoin(coin);
        }

        public double GetCoinTotal()
        {
            return _coinCollection.GetCoinTotal();
        }
    }
}