using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireButton : LogicWire {

    private GameObject player;
    private Transform playerTransform;
    private KeyInput keyInput;

    public Sprite buttonOn, buttonOff;
    public float reachDistance;
    public bool pressed = false;

    public GameObject[] IAffect;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("MainCharacter");
        playerTransform = player.transform;
        keyInput = GameObject.Find("KeyInputController").GetComponent<KeyInput>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(playerTransform.position, transform.position) < reachDistance)
        {
            GetComponent<SpriteRenderer>().sprite = buttonOn;
            
            pressed = true;
            pulse(pressed);
        }
        else
        {
            pressed = false;
            pulse(pressed);
            GetComponent<SpriteRenderer>().sprite = buttonOff;
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
