using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeImage : MonoBehaviour {
    public float tick;
    float nextTick = 0;
    // Use this for initialization
    void Start () {
      
    }

    public Sprite första;
    public Sprite andra;
    public Sprite tredje;

    // Update is called once per frame
    void Update () {
        if (nextTick > tick)
        {

                if (GetComponent<TakeDamageOnSurMark>().hp <= 25)
            {
                this.GetComponent<SpriteRenderer>().sprite = första;
            }
            else if (GetComponent<TakeDamageOnSurMark>().hp == 50)
            {
                this.GetComponent<SpriteRenderer>().sprite = andra;
            }
            else if (GetComponent<TakeDamageOnSurMark>().hp >= 75)
            {
                this.GetComponent<SpriteRenderer>().sprite = tredje;
            }

            if (Input.GetKey("g"))
            {
                GetComponent<TakeDamageOnSurMark>().hp = 50;
            }
            if (Input.GetKey("h"))
            {
                GetComponent<TakeDamageOnSurMark>().hp = 75;
                Debug.Log("Hello");
            }
            Debug.Log("Tick");
            nextTick -= tick;
        }
        nextTick += Time.deltaTime;
    }
}
