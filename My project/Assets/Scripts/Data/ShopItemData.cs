using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Shop Item Data", fileName = "NewShopItem")]
public class ShopItemData : ScriptableObject
{
    public string ItemId;
    public string ItemName;
    public Sprite Icon;
    [TextArea] public string Description;
    public int Price;
}
