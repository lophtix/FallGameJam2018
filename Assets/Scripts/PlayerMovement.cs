using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float vertical, horizontal;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speed* horizontal, speed* vertical, 0f);
	}

    public void setKeyInputs(float vertical, float horizontal)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
    }
}
