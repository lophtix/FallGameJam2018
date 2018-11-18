using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireButton : LogicWire {

    private GameObject[] players;
    private KeyInput keyInput;

    public Sprite buttonOn, buttonOff;
    public float reachDistance;
    public bool state = false;

    private Wire[] wires;
    public WireGate[] wireGates;
    public Gate[] gates;

    // Use this for initialization
    void Start () {
       
        keyInput = GameObject.Find("KeyInputController").GetComponent<KeyInput>();
        wires = gameObject.GetComponentsInChildren<Wire>();
    }
	
	// Update is called once per frame
	void Update () {
        players = GameObject.FindGameObjectsWithTag("Player");

        state = false;
        pulse(state);
        GetComponent<SpriteRenderer>().sprite = buttonOff;

        foreach (GameObject clone in players) {
            if (Vector2.Distance(clone.transform.position, transform.position) < reachDistance)
            {
                GetComponent<SpriteRenderer>().sprite = buttonOn;
                state = true;
                pulse(state);
            }
        }
    }



    public override void pulse(bool status)
    {
        foreach(Wire wire in wires)
        {
            wire.setStatus(status);
        }
        foreach (WireGate wireGate in wireGates)
        {
            wireGate.setStatus(status);
        }
        foreach (Gate gate in gates)
        {
            gate.setStatus(status);
        }
    }

    public override void setStatus(bool status)
    {
    }
}
