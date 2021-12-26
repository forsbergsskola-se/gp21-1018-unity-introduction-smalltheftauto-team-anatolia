using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Fix spelling: Waypoints instead of waypoints
public class waypoints : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(-0.01f,0,0*speed*Time.deltaTime);

    }
}
