using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenyExample : MonoBehaviour {

    public Text title;

    int numberOfClicks = 0;

    //public GameObject buttonPrefab;
    //public Transform buttonParent;

	// Use this for initialization
	void Start () {
        title.text = "Hello";

        //for (int i = 0; i < 5; i++)
        //{
        //    Instantiate(buttonPrefab, buttonParent);
        //}
	}
    
    public void ButtonPress(string name)
    {
        numberOfClicks++;
        title.text = "Button was pressed" + numberOfClicks;

        if (numberOfClicks >= 7)
        {
            SceneManager.LoadScene(name);
        }

    }
}
