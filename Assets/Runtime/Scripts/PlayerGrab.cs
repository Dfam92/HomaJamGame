using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{

    [SerializeField] Rigidbody playerRb;
    [SerializeField] FixedJoint hopeJoint;
    [SerializeField] HopeMovement hopeMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hopeJoint.connectedBody = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            hopeJoint.connectedBody = playerRb;
           
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hopeMove.HopeMoveControl();
        }
    }
}
