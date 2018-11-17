using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

    // Use this for initialization
    private PlayerMovement movement;
    private GameObject player;

    private bool justPressedUsed = false;
    private bool hasNotReleasedUse = false;

    void Start() {
        player = GameObject.Find("MainCharacter");


        movement = player.GetComponent<PlayerMovement>();
	}

	// Update is called once per frame
	void Update () {
        movement.setKeyInputs(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));

        if(Input.GetAxis("Use") != 0)
        {
            if (!hasNotReleasedUse)
            {
                justPressedUsed = true;
                hasNotReleasedUse = true;
            }
            else
            {
                justPressedUsed = false;
            }
        }
        else
        {
            hasNotReleasedUse = false;
        }
	}

    public bool getInputUse()
    {
        return Input.GetAxis("Use") != 0;
    }

    public bool getInputUsePressed()
    {
        return justPressedUsed;
    }


    
}
