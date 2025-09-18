using System.Collections.Generic;
using Bootstrapper;
using UnityEngine;

namespace Views
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField] private Transform itemsContainer;
        [SerializeField] private ShopItemView itemPrefab;

        private List<ShopItemView> _spawnedItems = new List<ShopItemView>();

        private void Start()
        {
            LoadShopItems();
        }

        private void LoadShopItems()
        {
            var shopItems = Resources.LoadAll<ShopItemData>("Items");

            foreach (var itemData in shopItems)
            {
                var itemView = Instantiate(itemPrefab, itemsContainer);
                itemView.Setup(itemData, GameBootstrapper.Instance.ShopController);
                _spawnedItems.Add(itemView);
            }
        }
    }
}