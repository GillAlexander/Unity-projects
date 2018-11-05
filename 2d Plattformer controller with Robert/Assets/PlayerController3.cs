using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour {

    Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {                   //Inbyggd acceleration
        float x = Input.GetAxis("Horizontal") * 5;

        rigidbody2D.velocity = (new Vector2(x, rigidbody2D.velocity.y));
    }
}
