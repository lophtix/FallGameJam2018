using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagController : MonoBehaviour {

    private GameObject[] players;

    public float reachDistance;

    // Use this for initialization
    void Start () {
        players = GameObject.FindGameObjectsWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject clone in players)
        {
            if (Vector2.Distance(clone.transform.position, transform.position) < reachDistance)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
