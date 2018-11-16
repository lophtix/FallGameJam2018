using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public GameObject Player; 

public class KeyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("MainCharacter");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode("W"))){
			Player.up = 1;
		} else if (Input.GetKey(KeyCode("S"))){
			Player.up = -1;
		} else {
			Player.up = 0;
		} 
		if (Input.GetKey(KeyCode("D"))){
			Player.right = 1;
		} else if (Input.GetKey(KeyCode("A"))){
			Player.right = -1;
		} else {
			Player.right = 0;
		}
		
	}
}
