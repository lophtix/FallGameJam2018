using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireLogicGate : LogicWire {

    public bool isAnAnd;

    public GameObject input1, input2;
    public GameObject output;

    bool status = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void setStatus(bool status)
    {
        this.status = status;
    }

    public override void pulse(bool status)
    {
        if (isAnAnd)
        {
        }
    }
}
