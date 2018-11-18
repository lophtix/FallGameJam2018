using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoice : MonoBehaviour {

    public int levelToSwitchTo;

    public void switchToLevel()
    {
        SceneManager.LoadScene(levelToSwitchTo);
        Time.timeScale = 1;
    }
}
