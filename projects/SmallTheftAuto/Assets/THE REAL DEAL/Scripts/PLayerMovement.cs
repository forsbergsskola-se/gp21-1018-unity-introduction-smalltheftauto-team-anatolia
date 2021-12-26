using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour //Watch for case typos /Ben
{
    public int coin = 0;
    public bool isHitting;
    

    void Update()
    {
        transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        
        //Could use Input.GetAxis("Horizontal") here as well /Ben
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -180f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 180f * Time.deltaTime);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(-256, 172, 160, 30), "Coin : " + coin);
    }

    private void OnCollisionEnter(Collision collision) //Maybe Move this to another script instead of the PlayerMovement one? /Ben
    {
        if (collision.gameObject.tag=="Enemy")
        {
            isHitting = true;
        }
        else
        {
            isHitting = false;
        }
    }
}


