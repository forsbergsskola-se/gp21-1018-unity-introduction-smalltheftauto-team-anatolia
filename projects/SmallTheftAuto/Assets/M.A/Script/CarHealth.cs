using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth<=0)
        {
            //burn
        }
    }


    void Update()
    {
        
    }
}
