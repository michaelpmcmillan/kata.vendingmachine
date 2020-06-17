namespace VendingMachineKata.Coin
{
    public interface ICoinCollection
    {
        void AddCoin(ICoin coin);
        double GetCoinTotal();
    }
}