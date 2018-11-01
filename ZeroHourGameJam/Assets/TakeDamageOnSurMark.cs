using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnSurMark : MonoBehaviour {

    public int hp = 0;
    public float tick;
    float nextTick = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.name == "SurMark")
        {
            hp -= 5;
        }
            if (Input.GetKey("g"))
            {
                hp += 5;
            }
            if (Input.GetKey("h"))
            {
                hp -= 5;
            Debug.Log("Hello");
            }

            

            Debug.Log("Tick");
            nextTick -= tick;
        }
        
    
}
