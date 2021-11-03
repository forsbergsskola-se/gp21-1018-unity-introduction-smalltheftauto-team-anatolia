using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;

    public int currentHealth;

    public HealthbarScript healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))        //every time you press Z it will take damage
        {
            TakeDamage(20);
        }
    }

    private void TakeDamage(int damage)     //Made a Method of taking damage
    {
        currentHealth -= damage;
        
        healthBar.SetHealth(currentHealth);
    }
}
