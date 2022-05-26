using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] PlayerMovement playerMove;
    [SerializeField] private float jumpPower;
    [SerializeField] private float jumpDuration;
    
    


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        
    }

    private void Jump()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
            playerRb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
       
    }
}
