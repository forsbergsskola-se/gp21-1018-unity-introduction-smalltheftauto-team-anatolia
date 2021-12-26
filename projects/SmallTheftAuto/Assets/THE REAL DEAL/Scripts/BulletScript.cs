using System; // TODO: Remove unnecessary using-statements
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // TODO: Remove redundant, empty functions
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="Enemie") // TODO: typo: 'Enemy'
        {
            Destroy(collision.gameObject);
        }
    }
}
