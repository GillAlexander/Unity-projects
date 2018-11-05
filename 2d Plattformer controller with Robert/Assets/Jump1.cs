using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump1 : MonoBehaviour {

    float jumpTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            jumpTime = Time.time + 0.065f;
        }
        if (Time.time < jumpTime)
        {
            transform.Translate(0, 0.20f, 0);
        }
	}
}
