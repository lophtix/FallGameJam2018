﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireGate : MonoBehaviour {

    private GameObject player;
    private Transform playerTransform;
    private KeyInput keyInput;

    public Sprite GateClosed, GateOpened;
    public float reachDistance;
    public bool state = false;

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
            if(state)
            {
                GetComponent<SpriteRenderer>().sprite = GateClosed;
                state = false;
            }
            else
            {
                state = true;
                GetComponent<SpriteRenderer>().sprite = GateOpened;
            }
        }
        
	}
}
