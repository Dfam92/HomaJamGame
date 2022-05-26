using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticForce : MonoBehaviour
{
    [SerializeField] Rigidbody playerRb;
    [SerializeField] float elasticPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerRb.AddForce(Vector3.up * elasticPower, ForceMode.Impulse);
        }
    }
}
