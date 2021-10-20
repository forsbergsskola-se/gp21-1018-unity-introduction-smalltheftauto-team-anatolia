using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementEU : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Easiest code to make Car move in Unity scripting. (automatic movement)
        
        
            transform.Translate(5f*Time.deltaTime*Input.GetAxis("Horizontal"), 0f, 0f);
            transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0f, 0f,.5f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0f, 0f,-.5f);
            }



    }
}
