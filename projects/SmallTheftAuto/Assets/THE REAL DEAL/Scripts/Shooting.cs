using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 50f;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // TODO: nice clean code! :)
        GameObject bullet =Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb= bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up*bulletForce,ForceMode.Impulse);
    }
}
