using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBattery : LogicWire {

    public GameObject[] connectedWires;

    public override void setStatus(bool status)
    {
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void pulse(bool status)
    {

    }
}
