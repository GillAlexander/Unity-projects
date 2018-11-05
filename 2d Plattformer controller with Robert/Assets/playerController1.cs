using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController1 : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        transform.Translate(x, 0, 0);

        float y = Input.GetAxis("Vertical");

    }
}
