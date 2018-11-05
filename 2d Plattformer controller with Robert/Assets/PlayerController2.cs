using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {

        rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") * 15;

        rigidbody2D.AddForce(new Vector2(x, 0));
    }
}
