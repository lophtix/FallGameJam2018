using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCredits : MonoBehaviour {

    public GameObject creditCanvas, menuCanvas;

	public void startCredits()
    {
        creditCanvas.SetActive(true);
        menuCanvas.SetActive(false);
    }

    public void quitCredits()
    {
        creditCanvas.SetActive(false);
        menuCanvas.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quitCredits();
        }
    }
}
