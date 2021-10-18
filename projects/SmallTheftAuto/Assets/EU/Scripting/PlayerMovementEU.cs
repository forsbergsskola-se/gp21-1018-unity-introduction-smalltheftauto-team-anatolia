using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //same thing with W key, if you press A, it will return True and go left
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f,0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.1f, 0f);
        }
            
    }
}
