using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump4 : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D rigidbody2D;
    float jumpMaxTime;
    float jumpTime;
    float jumpPower;

    public float testjumpMaxTime = 0.055f;
    public float testJumpTime = 0;
    public float testJumpPower = 2.4f;
    public bool isJumping;
    // Use this for initialization
    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();

        rigidbody2D.gravityScale = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            isJumping = true;
            jumpMaxTime = Time.time + testjumpMaxTime;
            jumpTime = testJumpTime;
            jumpPower = testJumpPower;
        }
        if (Input.GetButton("Jump") && Time.time < jumpMaxTime)
        {
            jumpTime += Time.deltaTime;
            
            rigidbody2D.velocity = (new Vector2(rigidbody2D.velocity.x, jumpPower));

            if (jumpTime < 0.45)
            {
                if (jumpPower < 8)
                {
                    jumpPower *= 1.2f;
                }
            }
            else
            {
                jumpPower *= 0.9f;
            }

            

            if (Input.GetButtonUp("Jump"))
            {
                jumpMaxTime = 0;
            }

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isJumping = false;
    }
}
