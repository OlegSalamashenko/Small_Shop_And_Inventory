using UnityEngine;
using TMPro;
using Bootstrapper;
using Controllers.Interfaces;

public class UICurrency : MonoBehaviour
{
    [SerializeField] private TMP_Text coinsText;

    private IPlayerWalletController _wallet;

    private void Start()
    {
        _wallet = GameBootstrapper.Instance.WalletController;
        _wallet.OnCoinsChanged += HandleCoinsChanged;

        Refresh();
    }

    private void HandleCoinsChanged(int newAmount) => coinsText.text = $"Coins: {newAmount}";
    
    public void Refresh()
    {
        if (_wallet == null) return;
        coinsText.text = $"Coins: {_wallet.Coins}";
    }
}