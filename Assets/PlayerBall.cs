﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public int itemCount;
    public GameManagerLogic manager;

    // GameManagerLogic Logic;
    Rigidbody rigid;
    //AudioSource Audio;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        //Audio = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            itemCount++;
            //AudioListener.volume = 0.5f;
            //Audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }  
        else if(other.tag == "Point")
        {
            if(itemCount == manager.TotalItemCount)
            {
                Debug.Log(manager.TotalItemCount);
                Debug.Log(itemCount);
                if(manager.stage == 4)
                {
                    SceneManager.LoadScene("Rest_Scene01");
                }
                else if(manager.stage == 8)
                {
                    SceneManager.LoadScene("Rest_Scene02");
                }
                else if(manager.stage == 12)
                {
                    SceneManager.LoadScene("IntroScene");
                }
                else
                {
                    //SceneManager.LoadScene("Scene" + (manager.stage + 1).ToString());
                    SceneManager.LoadScene(manager.stage + 1);
                }
            }
            else
            {
                /*
                  Change the Scene when Scene number is 4(or 7, 10)

                  The Scene Structor consists of 9 Stage, 
                  Left Panel is consists of Scene Name, and
                  Right Panel is consists of Real Scene Number.

                  For example, It looks like..
                  Intro = 1, Stage1 = 2, Stage2 = 3, Stage3 = 4.
                */
                // Intro = 1
                // Stage1 = 2
                // Stage2 = 3
                // Stage3 = 4
                //if (manager.stage == 4)
                //{
                //    SceneManager.LoadScene("Rest_Scene01");
                //}
                //else
                //{
                //    // SceneManager.LoadScene(manager.stage);
                //    SceneManager.LoadScene("Scene" + manager.stage.ToString());
                //}
                //SceneManager.LoadScene("Scene" + manager.stage.ToString());
                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
