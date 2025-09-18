using Controllers.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Views
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField] private Image icon;
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text priceText;
        [SerializeField] private Button buyButton;

        private ShopItemData _data;
        private IShopController _shopController;

        public void Setup(ShopItemData data, IShopController shopController)
        {
            _data = data;
            _shopController = shopController;

            icon.sprite = data.Icon;
            nameText.text = data.ItemName;
            priceText.text = data.Price.ToString();

            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(OnBuyClicked);
        }

        private void OnBuyClicked()
        {
            if (_shopController == null || _data == null) return;
            if (_shopController.TryPurchaseItem(_data, out string failReason))
            {
                Debug.Log($"Purchased {_data.ItemName}");
            }
            else
            {
                Debug.Log($"Purchase failed: {failReason}");
            }
        }
    }
}