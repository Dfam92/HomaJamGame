using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    private float playerSpeed = 5;
    [SerializeField] float turnSpeed;
    [SerializeField] float xBound;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerBound();
    }

    private void FixedUpdate()
    {
        PlayerForwardMovement();
        PlayerHorizontalMovement();
    }

    private void PlayerForwardMovement()
    {
        playerRb.AddForce(Vector3.forward * PlayerSpeed);
    }

    private void PlayerHorizontalMovement()
    {
       var horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * turnSpeed*horizontalInput);

    }

    private void PlayerBound()
    {
        if(transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
    }
}
