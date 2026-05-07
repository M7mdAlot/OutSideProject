using UnityEngine;

public class HpSystem
{
    public float Health = 100f;
    public void damage(float DamageAmount)
    {
        Health -= DamageAmount;

    }
    public void Heal(float HealAmount)
    {
        Health += HealAmount;
    }
    public HpSystem(float intialHealth)
    {
        Health = intialHealth;
    }
    public float GetHealth()
    {
        return Health;
    }
}
