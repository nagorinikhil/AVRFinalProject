using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTouchTrigger : MonoBehaviour {

    public GameObject ballPreFab;
    public float ballSpeed = 5.0f;


    void OnTriggerEnter(Collider collider)
    {
        GameObject instance = Instantiate(ballPreFab);
        instance.transform.position = new Vector3(3.5f, 3, 24.5f);
        //Rigidbody rb = instance.GetComponent<Rigidbody>();
        //Camera camera = GetComponentInChildren<Camera>();
        //rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
    }
}
