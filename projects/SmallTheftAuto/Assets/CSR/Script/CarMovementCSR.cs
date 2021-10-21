using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementCSR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        /*transform.Translate(1f*Time.deltaTime*Input.GetAxis("Horizontal"), 0f, 0f);
            transform.Translate(0f, 1f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);*/
            
        
        transform.Translate(-5f*Time.deltaTime*Input.GetAxis("Horizontal"),0f,0f);  
        transform.Translate(5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f, 0f);
        
        //rotate to the left.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -0.01f*Time.deltaTime);
        }
        //rotate to the right.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, 0.01f*Time.deltaTime);
        }
        
    }
}