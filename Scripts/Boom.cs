using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) {
            Rigidbody playerRig = other.gameObject.GetComponent<Rigidbody>();
            playerRig.AddForce(new Vector3(10f, 0, 20f));
            transform.gameObject.SetActive(false);
        }
    }
}
