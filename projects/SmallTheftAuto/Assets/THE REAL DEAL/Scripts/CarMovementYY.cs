using System;
using UnityEngine;


// TODO: fix naming. Why is there two car movement scripts?
public class CarMovementYY : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        transform.Translate(0f,-5f*Time.deltaTime*Input.GetAxis("Horizontal"),0f);
        // TODO: using Input.GetKey() is not recommended. Use Input.GetAxis() instead (Unity's Input Manager)
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
