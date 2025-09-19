using System.Collections.Generic;
using Bootstrapper;
using UnityEngine;

namespace Views
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private Transform itemsContainer;
        [SerializeField] private ShopItemView itemPrefab;

        private List<ShopItemView> _spawnedItems = new List<ShopItemView>();

        private void OnEnable()
        {
            RefreshInventory();
        }

        public void RefreshInventory()
        {
            foreach (var item in _spawnedItems)
                Destroy(item.gameObject);
            _spawnedItems.Clear();

            var items = GameBootstrapper.Instance.InventoryController.GetItems();
            foreach (var itemData in items)
            {
                var itemView = Instantiate(itemPrefab, itemsContainer);
                itemView.Setup(itemData, null);
                _spawnedItems.Add(itemView);
            }
        }
    }

}