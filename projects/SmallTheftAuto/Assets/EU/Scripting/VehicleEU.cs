using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEU : MonoBehaviour
{
    public GameObject player;
    public CarMovementEU carMovement;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (this.player.activeInHierarchy)
            {
                GetinCar();
            }
            else
            {
                this.player.transform.position = this.transform.position;
                this.player.SetActive(true);
                this.player.GetComponent<PlayerMovementEU>();
                GetComponent<CarMovementEU>().enabled = false;
            }
        }
    }

    private void GetinCar()
    {
        this.player.SetActive(false);
        this.carMovement.enabled = true;
    }
}
