using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour {
    public int tick = 0;
    public int loop = 0;
    public bool resetBool = false;

    public GameObject counter;

    void Start()
    {
        counter = GameObject.Find("CloneCounter");
    }

    void FixedUpdate () {
        tick += (int)Input.GetAxis("Timeshift") * 3 + 1;

        if (tick < 0) { tick = 0; }

        if (resetBool == true)
        {
            resetBool = false;
        }

        if (Input.GetButtonDown("Reset"))
        {
            TimeReset();
        }
	}

    void TimeReset()
    {
        tick = 1;
        
        resetBool = true;
        
        counter.GetComponent<Text>().text = "Clones: " + (loop + 1);
    }
}
