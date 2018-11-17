using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireCircuitContainer : LogicWire {

    public Wire[] wires;
    private bool currentState = false;

	// Use this for initialization
	void Start () {
        wires = gameObject.GetComponentsInChildren<Wire>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void setStatus(bool state)
    {
        if(state != currentState)
        {
            foreach(Wire wire in wires)
            {
                wire.setStatus(state);
            }
            currentState = state;
        }
    }

    public override void pulse(bool status)
    {
        setStatus(status);
    }
}
