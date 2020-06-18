using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Creator : MonoBehaviour
{
    public Button Back;

    // Go to Intro_Scene when User click 'Back' Button.
    public void ChangetoStartScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
