using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public int itemCount;
    public GameManagerLogic manager;

    GameManagerLogic Logic;
    Rigidbody rigid;
    AudioSource Audio;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        Audio = GetComponent<AudioSource>();
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
                // Change the Scene when Scene number is 4(or 8, 11)
                if (manager.stage == 4 || manager.stage == 8 || manager.stage == 11)
                {
                    SceneManager.LoadScene("Rest_Scene01");
                }
                else
                {
                    
                    SceneManager.LoadScene("Scene" + (manager.stage + 1).ToString());
                }
            }
            else
            {
                //SceneManager.LoadScene("IntroScene");
                SceneManager.LoadScene("Scene" + manager.stage.ToString());
            }
        }
    }
}
