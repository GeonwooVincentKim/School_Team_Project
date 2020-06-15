using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public int stage;
    public Button Start;
    public Button Settings;
    public Button Exit;

    // Go to First_Scene when User click 'Start' Button.
    public void ChangetoFirstScene()
    {
        SceneManager.LoadScene("Scene1");
    }

    // Go to Settings_Scene when User click 'Settings' Button. 
    public void ChangetoSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }

    // Finish the game when User click 'Exit' Button.
    
}
