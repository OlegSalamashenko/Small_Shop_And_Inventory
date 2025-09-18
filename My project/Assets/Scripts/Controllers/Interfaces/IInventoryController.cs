using System.Collections.Generic;

namespace Controllers.Interfaces
{
    public interface IInventoryController
    {
        void AddItem(ShopItemData item);
        IReadOnlyList<ShopItemData> GetItems();
    }
}