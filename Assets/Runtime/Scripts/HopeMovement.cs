using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopeMovement : MonoBehaviour
{
    private Rigidbody hopeRb;
    [SerializeField] private float maxDistance;
    // Start is called before the first frame update
    void Start()
    {
        hopeRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HopeMoveControl()
    {
        var finalPos1 = new Vector3(transform.position.x, 5, 14);
        var finalPos2 = new Vector3(transform.position.x, 1, 4);
        hopeRb.AddForce(Vector3.MoveTowards(finalPos1,finalPos2,maxDistance));
    }
}
