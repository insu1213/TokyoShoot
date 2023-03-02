using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    Rigidbody playerRig;
    void Start()
    {
        playerRig = transform.gameObject.GetComponent<Rigidbody>();
        playerRig.AddForce(new Vector3(0, 0, -20), ForceMode.Impulse);
    }

    void Update()
    {
        if(VelocityUpdate())
        {
            if (Input.GetKey(KeyCode.A))
            {
                playerRig.AddForce(new Vector3(1, 0, 0));
            }

            if (Input.GetKey(KeyCode.D))
            {
                playerRig.AddForce(new Vector3(-1, 0, 0));
            }
        }
    }

    bool VelocityUpdate()
    {
        if(playerRig.velocity.x > 10f || playerRig.velocity.x < -10f)
        {
            return false;
        }
        return true;
    }
}
