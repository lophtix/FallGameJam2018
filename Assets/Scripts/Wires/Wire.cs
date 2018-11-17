using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour {

    private bool isOn = false;
    private GameObject[] neighboringWires;

    public Animation wireOn;
    public Sprite wireOff;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setStatus(bool status)
    {
        isOn = status;
        if (status)
        {
            //gameObject.GetComponent<SpriteRenderer>().animation = wireOn;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = wireOff;
        }
    }
}
