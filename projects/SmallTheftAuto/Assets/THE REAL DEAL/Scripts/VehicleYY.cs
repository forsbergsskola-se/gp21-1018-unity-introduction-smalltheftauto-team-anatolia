using UnityEngine;

public class VehicleYY : MonoBehaviour
{
    public GameObject player;
    public CarMovementYY carMovementYY;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (this.player.activeInHierarchy) {
                this.player.SetActive(false);
                this.carMovementYY.enabled = true;
                FindObjectOfType<FollowTarget>().Target = transform;
            }
            else
            {
                this.player.transform.position = this.transform.position;
                this.player.SetActive(true);
                this.carMovementYY.enabled = false;
                FindObjectOfType<FollowTarget>().Target = player.transform;
            }
        }
    }
}
