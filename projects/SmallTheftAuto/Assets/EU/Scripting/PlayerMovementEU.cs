using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovementEU : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if you press the button W, it will return True and make the player move.
        //if you do not press the button W, it will return False and not make the player move.
        if (Input.GetKey(KeyCode.W))
        {
            //Easiest code to make player move in Unity scripting. (automatic movement)
            transform.Translate(0f, 0.01f, 0f);
        }
        
        //This makes the player rotate to the left.
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, 0.3f);
        }
        //This makes the player rotate to the right.
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -0.3f);
        }
        //Makes the player move backwards.
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.1f, 0f);
        }
        //Makes the player move to the left side.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        //Makes the player move to the right side.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f,0f);
        }
    }
}
