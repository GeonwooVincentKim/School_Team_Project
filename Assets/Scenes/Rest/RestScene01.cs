using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestScene01 : MonoBehaviour
{
    public Button Continue;
    public Button Back;
   
    public void ChangeToSecondScene()
    {
        SceneManager.LoadScene("Scene4");
    }

    public void ChangetoIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
