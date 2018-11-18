using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevelSelect : MonoBehaviour {

    public int levelSelectScene;

    public void goToLevelSelect()
    {
        SceneManager.LoadScene(levelSelectScene);
    }
}
