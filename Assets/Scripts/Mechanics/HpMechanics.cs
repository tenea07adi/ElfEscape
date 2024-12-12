using System;
using UnityEngine;

[Serializable]
public class HpMechanics
{
    [field: SerializeField]
    public int MaxHp { get; private set; }

    [field: SerializeField]
    public int CurrentHp { get; private set; }

    public bool IsAllive { get {  return CurrentHp > 0; } }

    public void DecreaseHp(int value)
    {
        CurrentHp = CurrentHp - value;

        BalanceHp();
    }

    public void IncreaseHp(int value)
    {
        CurrentHp = CurrentHp + value;

        BalanceHp();
    }

    public void Kill()
    {
        CurrentHp = 0;
    }

    public void ResetHp()
    {
        CurrentHp = MaxHp;
    }

    private void BalanceHp()
    {
        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
        else if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }
    }
}
