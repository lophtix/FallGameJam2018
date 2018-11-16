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
        movement.setDirection(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
	}

    
}
