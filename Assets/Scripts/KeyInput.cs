using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

    // Use this for initialization
    private PlayerMovement movement;
    private GameObject player;

    void Start() {
        player = GameObject.Find("MainCharacter");


        movement = player.GetComponent<PlayerMovement>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)){
            movement.up = 1;
		} else if (Input.GetKey(KeyCode.S)){
            movement.up = -1;
		} else {
            movement.up = 0;
		}
		if (Input.GetKey(KeyCode.D)){
            movement.right = 1;
		} else if (Input.GetKey(KeyCode.A)){
            movement.right = -1;
		} else {
            movement.right = 0;
		}

	}
}
