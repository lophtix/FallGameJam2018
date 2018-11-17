using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour {
    public int tick = 0;
    public int loop = 0;
    public bool resetBool = false;

    

	

	void FixedUpdate () {
        tick += (int)Input.GetAxis("Timeshift") * 3 + 1;
        print("Time: " + tick);

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
        tick = 0;
        
        resetBool = true;
    }
}
