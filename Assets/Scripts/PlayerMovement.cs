using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float vertical, horizontal;
    public float speed;
    private Rigidbody2D rb;

<<<<<<< HEAD
<<<<<<< HEAD
    private GameObject clock;
    private ClockScript time;
    private int tick;

    // Use this for initialization
    void Start () {
        clock = GameObject.Find("Clock");
        time = clock.GetComponent<ClockScript>();
        rb = GetComponent<Rigidbody2D>();
    }
=======
=======
>>>>>>> parent of 564e950... Added record+playback function
	// Use this for initialization
	void Start () {
		
	}
<<<<<<< HEAD
>>>>>>> parent of 564e950... Added record+playback function
=======
>>>>>>> parent of 564e950... Added record+playback function
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(speed* horizontal, speed* vertical, 0f);
	}

    public void setKeyInputs(float vertical, float horizontal)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
    }
}
