using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayback : MonoBehaviour {
    private GameObject clock;
    private ClockScript time;
    private int myTick;
    private int loop;

    private GameObject player;

    List<List<Vector3>> cloneArrays;
    MovementRecorder cloneArraysX;

    // Use this for initialization
    void Start () {
        print("start");
        player = GameObject.Find("MainCharacter");
        print("a" + player);
        cloneArraysX = player.GetComponent<MovementRecorder>();
        print("ca1");
        cloneArrays = cloneArraysX.getCloneArrays();
        print("ca" + cloneArrays);
        clock = GameObject.Find("Clock");
        time = clock.GetComponent<ClockScript>();
        print("time" + time);
    }

    private void FixedUpdate()
    {
        myTick = time.tick;
        if(time.loop > 0)
        {
            transform.position = cloneArrays[time.loop - 1][myTick];
        }
    }
}
