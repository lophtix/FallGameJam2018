using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireGate : MonoBehaviour {

    private GameObject player;
    private Transform playerTransform;
    private KeyInput keyInput;

    public Sprite GateClosed, GateOpened;
    public float reachDistance;

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
            if(GetComponent<SpriteRenderer>().sprite == GateOpened)
            {
                GetComponent<SpriteRenderer>().sprite = GateClosed;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = GateOpened;
            }
        }
        
	}
}
