using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireButtonContainer : LogicWire
{

    public Wire[] wires;
    public WireButton[] buttons;
    public Gate[] gates;
    public WireGate[] wireGates;
    public Sprite GateOn, GateOff;
    private SpriteRenderer spriteR;

    private bool currentButtonsState = false;
    private bool buttonsState = true;
    private bool currentWireGatesState = false;
    private bool wireGatesState = true;

    // Use this for initialization
    void Start()
    {
        wires = gameObject.GetComponentsInChildren<Wire>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (WireButton button in buttons)
        {
            if (!button.state)
            {
                buttonsState = false;
                break;
            }
            else
            {
                buttonsState = true;
            }
            if (buttonsState == true)
            {
                foreach (WireGate wireGate in wireGates)
                {
                    if (!wireGate.state)
                    {
                        wireGatesState = false; 
                        buttonsState = false;
                    }
                    else
                    {
                        wireGatesState = true;
                    }
                }
            }
        }
        if ((buttonsState != currentButtonsState) || (wireGatesState != currentWireGatesState))
        {
            foreach (Wire wire in wires)
            {
                wire.setStatus(buttonsState);
            }
            foreach (Gate gate in gates)
            {
                gate.setStatus(buttonsState);
            }

            if (buttonsState)
            {
                spriteR.sprite = GateOn;
            }
            else
            {
                spriteR.sprite = GateOff;
            }
            currentButtonsState = buttonsState;
            currentWireGatesState = wireGatesState;
        }
    }

    public override void setStatus(bool state)
    {
        
    }

    public override void pulse(bool status)
    {
 
    }
}
