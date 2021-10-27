using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{

    public Text healthText;
    public float health;
    public PlayerMovement PM;
    public EnemyDamage ED;
    public GameObject Player;

    public void Update()
    {
        healthText.text = "Health: " + health.ToString();
        if (PM.isHitting)
        {
            health -= ED.damage;
        }

        if (health <=0)
        {
            Player.gameObject.SetActive(false);
        }
    }

}
