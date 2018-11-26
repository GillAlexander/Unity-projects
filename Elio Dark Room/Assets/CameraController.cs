using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    Vector2 mouseLook;

    public float sensitivity;

    GameObject character; 

	// Use this for initialization
	void Start () {
        character = this.transform.parent.gameObject;

	}
	
	// Update is called once per frame
	void Update () {
        Vector2 cameraChange = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        cameraChange = Vector2.Scale(cameraChange, new Vector2(sensitivity, sensitivity));

        mouseLook += cameraChange;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90, 90);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);


	}
}
