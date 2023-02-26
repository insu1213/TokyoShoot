using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    Rigidbody playerRig;
    void Start()
    {
        playerRig = transform.gameObject.GetComponent<Rigidbody>();   
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            playerRig.AddForce(new Vector3(-10, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRig.AddForce(new Vector3(10, 0, 0));
        }
    }
}
