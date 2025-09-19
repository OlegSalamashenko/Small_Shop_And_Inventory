using Controllers.Interfaces;

namespace Controllers
{
    public class ShopController : IShopController
    {
        private readonly IInventoryController _inventory;
        private readonly IPlayerWalletController _wallet;

        public ShopController(IInventoryController inventory, IPlayerWalletController wallet)
        {
            _inventory = inventory;
            _wallet = wallet;
        }

        public bool TryPurchaseItem(ShopItemData item, out string failReason)
        {
            if (item == null)
            {
                failReason = "Invalid item";
                return false;
            }

            if (_wallet.TrySpendCoins(item.Price))
            {
                _inventory.AddItem(item);
                failReason = null;
                return true;
            }

            failReason = "Not enough coins";
            return false;
        }
    }

}