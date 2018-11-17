using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRecorder : MonoBehaviour {
    private GameObject clock;
    private ClockScript time;
    private int tick;


    List<Vector3> playerArray = new List<Vector3>();
    List<List<Vector3>> cloneArrays = new List<List<Vector3>>();

    // Use this for initialization
    void Start () {
        clock = GameObject.Find("Clock");
        time = clock.GetComponent<ClockScript>();
    }

    void FixedUpdate()
    {
        tick = time.tick;
        
        playerArray.Add(transform.position);
        
        if (time.tick == 199) {
            cloneArrays.Add(playerArray);
            playerArray = new List<Vector3>();
        }
    }

    public List<List<Vector3>> getCloneArrays()
    {
        return cloneArrays;
    }
}
