using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneration : MonoBehaviour {

    public GameObject ballPreFab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateBall()
    {
        GameObject instance = Instantiate(ballPreFab);
        instance.transform.position = new Vector3(0, -0.111f, 20.71f);
    }
}
