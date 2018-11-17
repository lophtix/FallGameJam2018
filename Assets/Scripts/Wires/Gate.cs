using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : LogicWire {

    public bool state;
    public Sprite GateOpen, GateClosed;
    private BoxCollider2D bc;

    // Use this for initialization
    void Start () {
        bc = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void pulse(bool status)
    {

        if (status)
        {
            GetComponent<SpriteRenderer>().sprite = GateOpen;
            bc.enabled = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = GateClosed;
            bc.enabled = true;
        }
    }

    public override void setStatus(bool status)
    {
        
    }
}
