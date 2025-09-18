namespace Controllers.Interfaces
{
    public interface IShopController
    {
        bool TryPurchaseItem(ShopItemData item, out string failReason);
    }

}