using TMPro;
using UnityEngine;
using Zenject;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    private Wallet _wallet;
    
    [Inject]
    private void Inject(Wallet wallet) => _wallet = wallet;

    private void Awake() => _wallet.OnMoneyChanged += UpdateUI;

    private void UpdateUI(int money) => moneyText.text = money.ToString();

    private void OnDestroy() => _wallet.OnMoneyChanged -= UpdateUI;
}