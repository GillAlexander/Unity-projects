using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D playerBody;

	// Use this for initialization
	void Start () {
        playerBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;


        Vector2 movement = new Vector2(x, y);

        playerBody.AddForce(movement);
    }
}
