using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMA : MonoBehaviour
{
    public GameObject Player;

    public CarMovmentMA CarMovmentMA;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (this.Player.activeInHierarchy)
            {
                this.Player.SetActive(false);
                this.CarMovmentMA.enabled = true;
            }
            else
            {
                this.Player.transform.position = this.transform.position;
                this.Player.SetActive(true);
                this.CarMovmentMA.enabled = false;
            }
            
        }
    }
}
