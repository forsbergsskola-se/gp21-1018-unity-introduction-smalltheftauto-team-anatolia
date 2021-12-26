using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float moveSpeed;
    public int health;
    public int damage;
    public Transform targetTransform;

    void FixedUpdate()
    {
        if (targetTransform != null)
        {
            // TODO: Smart, simple traffic script
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetTransform.transform.position, Time.deltaTime * moveSpeed);
        }
    }

    // TODO: Too bad that this wasn't finished (used by other components) :(
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Attack(PLayerMovement player)
    {
        Destroy(this.gameObject);
    }

    public void Initialize(Transform target, float moveSpeed, int health)
    {
        this.targetTransform = target;
        this.moveSpeed = moveSpeed;
        this.health = health;
    }

}
