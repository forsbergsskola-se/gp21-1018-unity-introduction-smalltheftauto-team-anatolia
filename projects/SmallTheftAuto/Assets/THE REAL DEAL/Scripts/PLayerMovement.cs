using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }
=======
    public int points = 0;
    public bool isHitting;
    
>>>>>>> d9f41b07b7928f00982a37735513afe263a7c109

    void Update()
    {
<<<<<<< HEAD
        // if player presses W  key
        if (Input.GetKey(KeyCode.W))
        {
            // then set the isWalking boolean to be true
            animator.SetBool("isWalking", true);
        }
=======
        transform.Translate(0f, -5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
>>>>>>> d9f41b07b7928f00982a37735513afe263a7c109
=======
    public int points = 0;
    public bool isHitting;
    

    void Update()
    {
        transform.Translate(0f, -5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
>>>>>>> d9f41b07b7928f00982a37735513afe263a7c109

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -180f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, 180f * Time.deltaTime);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(-256, 172, 160, 30), "Coin : " + points);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Enemy")
        {
            isHitting = true;
        }
        else
        {
            isHitting = false;
        }
    }
}


