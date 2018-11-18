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
    private bool state = false;

    // Use this for initialization
    void Start()
    {
        wires = gameObject.GetComponentsInChildren<Wire>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(buttonsState + "  " + wireGatesState);
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
            
        }
        foreach (WireGate wireGate in wireGates)
        {
            if (!wireGate.state)
            {
                wireGatesState = false;
                break;
            }
            else
            {
                wireGatesState = true;
            }
        }
        if ((buttonsState != currentButtonsState) || (wireGatesState != currentWireGatesState))
        {
            if (buttonsState && wireGatesState)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            foreach (Wire wire in wires)
            {
                wire.setStatus(state);
            }
            foreach (Gate gate in gates)
            {
                gate.setStatus(state);
            }

            if (state)
            {
                spriteR.sprite = GateOn;
            }
            else
            {
                spriteR.sprite = GateOff;
            }
        }

        if (buttons.Length > 0)
        {
            currentButtonsState = buttonsState;
        }
        else if (wireGates.Length > 0)
        {
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
