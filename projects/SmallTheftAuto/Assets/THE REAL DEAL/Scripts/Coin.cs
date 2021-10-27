using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerMovement>().points++;
            Destroy(gameObject);
        }
    }
}
