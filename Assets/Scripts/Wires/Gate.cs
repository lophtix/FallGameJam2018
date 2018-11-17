using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : LogicWire {

    public bool state;
    public Sprite GateOpen, GateClosed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void pulse(bool status)
    {

        if (status)
        {
            
            GetComponent<SpriteRenderer>().sprite = GateOpen;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = GateClosed;
        }
    }

    public override void setStatus(bool status)
    {
        
    }
}
