using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float vertical, horizontal;
    public float speed;
    private Rigidbody2D rb;

    private GameObject clock;
    private ClockScript time;
    private int tick;

    // Use this for initialization
    void Start () {
        clock = GameObject.Find("Clock");
        time = clock.GetComponent<ClockScript>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(speed* horizontal, speed* vertical, 0f);
	}

    private void FixedUpdate()
    {
        
    }

    public void setKeyInputs(float vertical, float horizontal)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;

    }
}
