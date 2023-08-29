using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private Wallet _wallet;

    [Inject]
    private void Inject(Wallet wallet) => _wallet = wallet;

    private void Start() => _wallet.Earn(100);
}