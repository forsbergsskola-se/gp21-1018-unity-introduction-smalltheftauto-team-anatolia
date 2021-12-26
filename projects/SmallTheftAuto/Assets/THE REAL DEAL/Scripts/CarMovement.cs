using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    void Start()
        {
            
        }
    
        
        void Update()
        {
            // TODO: transform.translate is not physics based movement using acceleration or breaking
            transform.Translate(0f, 0f, 180f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
            transform.Translate(0f,-5*Time.deltaTime*Input.GetAxis("Horizontal"),0f);
            if (Input.GetKey(KeyCode.A))
            { // TODO: Vehicles do not rotate like people do (on the spot)
                transform.Rotate(0f,0f,180f*Time.deltaTime);
            }
    
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0f,0f,-180f*Time.deltaTime);
            }
        }
    }
