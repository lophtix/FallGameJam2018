using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireButton : LogicWire {

    private GameObject[] players;
    private KeyInput keyInput;

    public Sprite buttonOn, buttonOff;
    public float reachDistance;
    public bool pressed = false;

    public GameObject[] IAffect;

    // Use this for initialization
    void Start () {
       
        keyInput = GameObject.Find("KeyInputController").GetComponent<KeyInput>();
    }
	
	// Update is called once per frame
	void Update () {
        players = GameObject.FindGameObjectsWithTag("Player");
        //print(players.Length);

        pressed = false;
        pulse(pressed);
        GetComponent<SpriteRenderer>().sprite = buttonOff;

        foreach (GameObject clone in players) {
            if (Vector2.Distance(clone.transform.position, transform.position) < reachDistance)
            {
                GetComponent<SpriteRenderer>().sprite = buttonOn;

                pressed = true;
                pulse(pressed);
            }
        }
    }



    public override void pulse(bool status)
    {
        foreach(GameObject obj in IAffect)
        {
            obj.GetComponent<LogicWire>().pulse(pressed);
        }
    }

    public override void setStatus(bool status)
    {
    }
}
