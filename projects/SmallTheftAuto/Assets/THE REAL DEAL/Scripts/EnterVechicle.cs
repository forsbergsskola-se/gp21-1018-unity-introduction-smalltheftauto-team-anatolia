using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterVechicle : MonoBehaviour
{
    public GameObject Player;
    public CarMovement CarMovement;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (this.Player.activeInHierarchy)
            {
                this.Player.SetActive(false);
                GetComponent<CarMovement>().enabled = true;
            }
            else
            {
                this.Player.transform.position = this.transform.position;
                this.Player.SetActive(true);
                this.Player.GetComponent<CarMovement>();
                GetComponent<CarMovement>().enabled = false;
            }
        }
    }
}
