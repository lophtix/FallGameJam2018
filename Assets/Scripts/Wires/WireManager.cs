using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void reLogic()
    {
        resetAllWires();
    }

    private void resetAllWires()
    {
        GameObject[] wires = GameObject.FindGameObjectsWithTag("LogicWire");
        foreach(GameObject wire in wires)
        {
            wire.GetComponent<LogicWire>().setStatus(false);
        }
    }

    
}
