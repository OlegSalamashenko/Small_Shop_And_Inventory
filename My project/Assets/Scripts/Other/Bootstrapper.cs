using Controllers;
using Controllers.Interfaces;
using UnityEngine;

namespace Bootstrapper
{
    public class GameBootstrapper : MonoBehaviour
    {
        public static GameBootstrapper Instance { get; private set; }

        [SerializeField] private int startingCoins = 100;

        public IShopController ShopController { get; private set; }
        public IInventoryController InventoryController { get; private set; }
        public IPlayerWalletController WalletController { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
            InventoryController = new InventoryController();
            WalletController = new PlayerWalletController(startingCoins);
            ShopController = new ShopController(InventoryController, WalletController);
        }
    }
}