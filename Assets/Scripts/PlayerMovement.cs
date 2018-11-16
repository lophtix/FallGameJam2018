using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float up, right;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speed*right, speed*up, 0f);
        Debug.Log(right);
	}

    public void setDirection(float up, float right)
    {
        this.up = up;
        this.right = right;
    }
}
