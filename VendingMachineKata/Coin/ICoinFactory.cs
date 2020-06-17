namespace VendingMachineKata.Coin
{
    public interface ICoinFactory
    {
        ICoin Create(int value);
    }
}
