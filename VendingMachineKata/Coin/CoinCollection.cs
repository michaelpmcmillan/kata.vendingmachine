using System.Collections.Generic;
using System.Linq;

namespace VendingMachineKata.Coin
{
    public class CoinCollection : List<ICoin>, ICoinCollection
    {
        public void AddCoin(ICoin coin)
        {
            if (coin != null)
            {
                base.Add(coin);
            }
        }

        public double GetCoinTotal()
        {
            return this.Sum(coin => coin.Value);
        }
    }
}