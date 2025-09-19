using System.Collections.Generic;
using Controllers.Interfaces;

namespace Controllers
{
    public class InventoryController : IInventoryController
    {
        private readonly List<ShopItemData> _items = new List<ShopItemData>();

        public void AddItem(ShopItemData item)
        {
            if (item == null) return;
            _items.Add(item);
        }

        public IReadOnlyList<ShopItemData> GetItems() => _items.AsReadOnly();
        
    }

}