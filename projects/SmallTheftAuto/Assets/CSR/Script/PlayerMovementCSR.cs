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
    /*void Update()
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
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 0.03f);
        }
        //rotate to the right.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -0.05f);
        }
        
    }
}*/

    void Update()
    {
        
        /*transform.Translate(1f*Time.deltaTime*Input.GetAxis("Horizontal"), 0f, 0f);
            transform.Translate(0f, 1f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);*/
            
        
        
        transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        transform.Translate(0f,-5f*Time.deltaTime*Input.GetAxis("Horizontal"),0f);
        
        
        //rotate to the left.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 0.01f*Time.deltaTime);
        }
        //rotate to the right.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -0.01f*Time.deltaTime);
        }
        
    }
}