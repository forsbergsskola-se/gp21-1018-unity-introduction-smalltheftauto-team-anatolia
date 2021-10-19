using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCSR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0.001f, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f,-0.001f,0f);
        }
        
        //rotira se na lijevo?.
        
        //rotate to the left.
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, 0.03f);
        }
        //rotate to the right.
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -0.05f);
        }
        
    }
}