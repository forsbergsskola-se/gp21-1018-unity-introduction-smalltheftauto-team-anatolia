using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colliding : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        // TODO: cool, but too bad that this does not interact with the player in a vehicle
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("You Dead");
        }
    }
}

