using VendingMachineKata.Coin;

namespace VendingMachineKata
{
    public interface IVendingMachine
    {
        void InsertCoin(ICoin coin);
        double GetCoinTotal();
    }
}
