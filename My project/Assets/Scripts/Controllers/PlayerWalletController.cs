using System;
using Controllers.Interfaces;
using UnityEngine;

namespace Controllers
{
    public class PlayerWalletController : IPlayerWalletController
    {
        public int Coins { get; private set; }
        public event Action<int> OnCoinsChanged;
        public PlayerWalletController(int startingCoins) => Coins = Mathf.Max(0, startingCoins);
        public bool TrySpendCoins(int amount)
        {
            if (amount <= 0) return true;
            if (Coins >= amount)
            {
                Coins -= amount;
                OnCoinsChanged?.Invoke(Coins);
                return true;
            }
            return false;
        }
    }
}