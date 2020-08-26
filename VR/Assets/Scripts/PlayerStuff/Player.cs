using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int maxHealth = 5;
    int currentHealth;
    bool Invulnerable = false;
    private void Awake()
    {
        instance = this;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int dmg)
    {
        if (!Invulnerable)
        {
            currentHealth -= dmg;
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public int CurrentHealth()
    {
        return currentHealth;
    }

    public void MakeInvulnerable(bool answer)
	{
        Invulnerable = answer;
	}

    
}
