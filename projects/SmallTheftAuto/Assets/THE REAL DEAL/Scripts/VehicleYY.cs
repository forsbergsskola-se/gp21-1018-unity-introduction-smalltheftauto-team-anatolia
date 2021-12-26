using UnityEngine;

public class VehicleYY : MonoBehaviour
{
    public GameObject player;
    public CarMovementYY carMovement;
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
                this.player.GetComponent<PLayerMovement>();
                GetComponent<CarMovementYY>().enabled = false;
            }
        }
    }

    // TODO: Fix spelling PlayerIn instead of Playerin
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
