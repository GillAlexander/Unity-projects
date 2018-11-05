using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2D.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
        }
    }
}
