namespace VendingMachineKata.Coin
{
    public class CoinFactory : ICoinFactory
    {
        public ICoin Create(int value)
        {
            return new Nickle();
        }
    }
}