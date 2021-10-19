using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
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
            //Easiest code to make player move in Unity scripting. (automatic movement)
            transform.Translate(0f, 0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Easiest code to make player move in Unity scripting. (automatic movement)
            transform.Translate(0f, -0.01f, 0f);
        }
    }
}
