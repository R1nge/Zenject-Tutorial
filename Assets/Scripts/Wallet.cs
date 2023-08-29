using System;
using UnityEngine;

public class Wallet
{
    public event Action<int> OnMoneyChanged;
    private int _currentMoney;

    public void Earn(int amount)
    {
        if (amount <= 0)
        {
            Debug.LogError($"Trying to earn {amount}");
            return;
        }

        _currentMoney += amount;
        OnMoneyChanged?.Invoke(_currentMoney);
        Log(_currentMoney);
    }

    public bool Spend(int amount)
    {
        if (amount <= 0)
        {
            Debug.LogError($"Trying to spend {amount}");
            return false;
        }

        if (_currentMoney - amount < 0)
        {
            Debug.LogError("Not enough money");
            return false;
        }

        _currentMoney -= amount;
        OnMoneyChanged?.Invoke(_currentMoney);
        Log(_currentMoney);
        return true;
    }

    private void Log(int money) => Debug.Log(money);
}