using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    Rigidbody playerRig;
    void Start()
    {
        playerRig = transform.gameObject.GetComponent<Rigidbody>();
        playerRig.AddForce(new Vector3(0, 0, -200), ForceMode.Impulse);
    }

    void Update()
    {
        VelocityUpdate();
        if(Input.GetKey(KeyCode.A))
        {
            playerRig.AddForce(new Vector3(20, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRig.AddForce(new Vector3(-20, 0, 0));
        }
    }

    void VelocityUpdate()
    {

    }
}
