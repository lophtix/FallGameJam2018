using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour {
    public int tick = 0;
    public int loop = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        tick += 1;
        if (tick == 200)
        {
            tick = 0;
            loop += 1;
            print("loop: " + loop);
        }
	}
}
