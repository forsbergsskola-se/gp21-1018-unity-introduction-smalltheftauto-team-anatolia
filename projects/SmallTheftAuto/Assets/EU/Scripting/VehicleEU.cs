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
            if (PlayerinCar())
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

    private bool PlayerinCar()
    {
        return this.player.activeInHierarchy;
    }

    private void GetinCar()
    {
        this.player.SetActive(false);
        this.carMovement.enabled = true;
    }
}
