using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireGate : LogicWire {

    private GameObject player;
    private Transform playerTransform;
    private KeyInput keyInput;

    public Sprite GateClosed, GateOpened;
    public float reachDistance;
    public bool state = false;
    public bool open = false;



	// Use this for initialization
	void Start () {
        player = GameObject.Find("MainCharacter");
        playerTransform = player.transform;
        keyInput = GameObject.Find("KeyInputController").GetComponent<KeyInput>();

    }
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(playerTransform.position, transform.position) < reachDistance && keyInput.getInputUsePressed())
        {
            if(open)
            {
                GetComponent<SpriteRenderer>().sprite = GateClosed;
                open = false;
            }
            else
            {
                open = true;
                GetComponent<SpriteRenderer>().sprite = GateOpened;
            }
        }
        
	}

    public override void setStatus(bool state)
    {
        this.state = state;
    }

    public override void pulse(bool status)
    {

    }
}
