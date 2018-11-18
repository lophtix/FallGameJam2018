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

    public GameObject pauseCanvas, rewindCanvas;
    private bool pause = false;

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

        testForPause();
        testForRewind();
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
                pauseCanvas.SetActive(true);
                pause = true;
                Time.timeScale = 0;
            }
            
        }
    }

    public void unPause()
    {
        pauseCanvas.SetActive(false);
        pause = false;
        Time.timeScale = 1;
    }

    private void testForRewind()
    {
        if(Input.GetAxis("Timeshift") < 0)
        {
            rewindCanvas.SetActive(true);
        }
        else
        {
            rewindCanvas.SetActive(false);
        }
    }
    
}
