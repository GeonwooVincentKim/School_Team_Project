﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScene : MonoBehaviour
{
    public Button Start;
    public Button Settings;
    public Button Exit;

    // Go to First_Scene when User click 'Start' Button.
    public void ChangetoFirstScene()
    {
        SceneManager.LoadScene("Scene1");
        //SceneManager.LoadScene("Scene" + (manager.stage + 1).ToString());
    }

    // Go to Creator_Scene when User click 'Creator' Button. 
    public void ChangetoSettingsScene()
    {
        SceneManager.LoadScene("Creator");
    }

    // Finish the game when User click 'Exit' Button.
    public void GameExit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
