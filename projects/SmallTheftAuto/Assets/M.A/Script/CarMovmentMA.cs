using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarMovmentMA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        transform.Translate(0f,-5f*Time.deltaTime*Input.GetAxis("Horizontal"),0f);

        
        }
    }


