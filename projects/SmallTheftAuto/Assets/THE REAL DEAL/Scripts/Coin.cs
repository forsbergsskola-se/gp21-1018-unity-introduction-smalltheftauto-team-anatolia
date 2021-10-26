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
        if (other.name == "Tank")
        {
            other.GetComponent<CarMovementYY>().points++;
            Destroy(gameObject);
        }
    }
}
