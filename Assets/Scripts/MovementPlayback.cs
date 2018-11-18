using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayback : MonoBehaviour {
    private GameObject clock;
    private ClockScript time;
    private int tick;
    private int loop;

    public int instantiatedLoop = 0;

    private GameObject player;

    List<List<Vector3>> cloneArrays;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("MainCharacter");
        cloneArrays = player.GetComponent<MovementRecorder>().getCloneArrays();

        clock = GameObject.Find("Clock");
        time = clock.GetComponent<ClockScript>();
    }

    private void FixedUpdate()
    {
        tick = time.tick;
        if (tick < cloneArrays[instantiatedLoop].Count)
        {
            transform.position = cloneArrays[instantiatedLoop][tick - 1];
        } else
        {
            transform.position = new Vector3(-50f, 50f, 0f);
        }
        
    }
}
