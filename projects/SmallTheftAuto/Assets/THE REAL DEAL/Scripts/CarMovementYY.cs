using System;
using UnityEngine;


public class CarMovementYY : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        transform.Translate(0f,-5f*Time.deltaTime*Input.GetAxis("Horizontal"),0f);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 180f*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f,0f,-180f*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0f, 15 * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        }
    }
}
