using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestScene02 : MonoBehaviour
{
    public Button Continue;
    public Button Back;

    public void ChangetoThridScene()
    {
        SceneManager.LoadScene("Scene7");
    }

    public void ChangetoIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
