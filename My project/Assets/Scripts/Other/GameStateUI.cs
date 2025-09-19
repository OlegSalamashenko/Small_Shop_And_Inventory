using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using Views;

public class GameStateUI : MonoBehaviour
{
    [SerializeField] private GameObject shop;
    [SerializeField] private GameObject inventory;
    
    public void ShowShop()
    {
        shop.SetActive(true);
        inventory.SetActive(false);
    }

    public void ShowInventory()
    {
        shop.SetActive(false);
        inventory.SetActive(true);
        inventory.GetComponent<InventoryView>().RefreshInventory();
    }
}
