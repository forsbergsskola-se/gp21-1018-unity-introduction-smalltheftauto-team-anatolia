using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int points = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0f, -5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f,0f,-180f*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, 180f * Time.deltaTime);
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(-256,172,160,30),"Coin : " + points);
    }
}
