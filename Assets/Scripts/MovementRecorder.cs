using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRecorder : MonoBehaviour {
    private GameObject clock;
    private ClockScript time;
    private int tick;

    public GameObject clone;

    List<Vector3> playerArray = new List<Vector3>(new Vector3[500]);
    List<List<Vector3>> cloneArrays = new List<List<Vector3>>();

    // Use this for initialization
    void Start () {
        clock = GameObject.Find("Clock");
        time = clock.GetComponent<ClockScript>();
       
    }

    void FixedUpdate()
    {
        tick = time.tick;
        
        if (playerArray.Count < tick + 2)
        {
            playerArray.Add(new Vector3(0f, 0f, 0f));
            if (playerArray.Count < tick + 2)
            {
                playerArray.Add(new Vector3(0f, 0f, 0f));
            }
        }
        

        playerArray[tick] = transform.position;

        if (Input.GetAxis("Timeshift") < 0)
        {
            print("rewinding");
            transform.position = playerArray[tick-1];
        }

        if (time.resetBool == true) {
            cloneArrays.Add(playerArray);
            playerArray = new List<Vector3>();
            transform.position = new Vector3(0f, 0f, 0f);

            time.loop += 1;
            clone.GetComponent<MovementPlayback>().instantiatedLoop = time.loop - 1;
            Instantiate(clone);
        }
    }

    public List<List<Vector3>> getCloneArrays()
    {
        return cloneArrays;
    }
}
