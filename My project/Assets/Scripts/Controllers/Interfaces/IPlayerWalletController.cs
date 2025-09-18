using System;

namespace Controllers.Interfaces
{
    public interface IPlayerWalletController
    {
        int Coins { get; }
        event Action<int> OnCoinsChanged;
        bool TrySpendCoins(int amount);
    }
}