using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneController : MonoBehaviour {

    private Transform lastTransform;
    public Sprite front, back, side;

	// Use this for initialization
	void Start () {
        lastTransform = transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       // animations();
	}

    //private void animations()
    //{
    //    Vector3 delta = lastTransform.position - transform.position;

    //    print("delta: " + delta);

    //    if (delta.y == 0 && delta.x > 0)
    //    {
    //        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = side;
    //        gameObject.GetComponentInChildren<SpriteRenderer>().flipX = false;
    //    }
    //    else if (delta.y == 0 && delta.x < 0)
    //    {
    //        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = side;
    //        gameObject.GetComponentInChildren<SpriteRenderer>().flipX = true;
    //    }
    //    else if (delta.y > delta.x)
    //    {
    //        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = back;
    //    }
    //    else if (delta.y < delta.x)
    //    {
    //        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = front;
    //    }

    //    lastTransform = transform;

    //}
}
