using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour {

    // Use this for initialization
    private PlayerMovement movement;
    private GameObject player;

    private bool justPressedUsed = false;
    private bool hasNotReleasedUse = false;

    private bool pause = false;

    void Start() {
        player = GameObject.Find("MainCharacter");


        movement = player.GetComponent<PlayerMovement>();

        GameObject.FindObjectOfType<Canvas>().enabled = false;
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

        testForPause();
	}

    public bool getInputUse()
    {
        return Input.GetAxis("Use") != 0;
    }

    public bool getInputUsePressed()
    {
        return justPressedUsed;
    }

    private void testForPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                unPause();
                
            }
            else
            {
                GameObject.FindObjectOfType<Canvas>().enabled = true;
                pause = true;
                Time.timeScale = 0;
            }
            
        }
    }

    public void unPause()
    {
        GameObject.FindObjectOfType<Canvas>().enabled = false;
        pause = false;
        Time.timeScale = 1;
    }
    
}
