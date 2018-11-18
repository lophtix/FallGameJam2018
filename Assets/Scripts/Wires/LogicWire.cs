using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LogicWire : MonoBehaviour {

    public GameObject[] Outputs;
    public GameObject[] Inputs;

    //public void Start()
    //{
    //    foreach(GameObject obj in Outputs)
    //    {

    //    }
    //}

    public abstract void setStatus(bool status);

    public abstract void pulse(bool status);

}
