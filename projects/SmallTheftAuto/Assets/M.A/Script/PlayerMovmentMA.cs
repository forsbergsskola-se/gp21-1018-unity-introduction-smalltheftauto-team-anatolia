using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentMA : MonoBehaviour
{
    public HealthbarBehaviourMA Healthbar;
    public float Hitpoints;
    public float MaxHitpoints = 5;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints,MaxHitpoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if (Hitpoints<=0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
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
    }
}
