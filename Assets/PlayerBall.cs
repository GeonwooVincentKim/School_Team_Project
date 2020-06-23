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
                SceneManager.LoadScene("Scene" + (manager.stage + 1).ToString());

                //if (manager.stage == 3)
                //{
                //    SceneManager.LoadScene("Rest_Scene01");
                //}
                //else if (manager.stage == 7 || manager.stage == 11)
                //{
                //    SceneManager.LoadScene("Rest_Scene02");
                //}
                //else
                //{ 
                //    //SceneManager.LoadScene("Rest_Scene01");
                //}
            }
            else
            {
                // Change the Scene when Scene number is 3(or 7, 11)
                if (manager.stage == 4)
                {
                    SceneManager.LoadScene("Rest_Scene01");
                }
                else
                    SceneManager.LoadScene("Scene" + manager.stage.ToString());
            }
        }
    }
}
