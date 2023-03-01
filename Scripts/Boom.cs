using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public GameObject UICanvas;
    UIManager uiManager;
    void Start()
    {
 
    }

    void Update()
    {
        uiManager = UICanvas.GetComponent<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) {
            Rigidbody playerRig = other.gameObject.GetComponent<Rigidbody>();
            uiManager.Damaged(0.1f);
            playerRig.AddForce(new Vector3(100f, 0, 200f));
            transform.gameObject.SetActive(false);
        }
    }
}
