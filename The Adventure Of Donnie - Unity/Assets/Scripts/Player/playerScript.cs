using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class playerScript : MonoBehaviour
{

    public GameObject HeartImage1;
    public GameObject HeartImage2;
    public GameObject HeartImage3;
    //public int Heart = 3;
    public GameObject GameOverPanel;
    //public GameObject notEnough;
    //public GameObject win;

    public TMP_Text coinText;
    //public int Coin;

    public string retryScene;

    public Transform playerSpawn;
    public PlayerMovement Movement;
    public Battle_Donnie[] donnie;

    public Transform newPos;

    //public GameObject heart;

    void Start()
    {
        //Time.timeScale = 1f;
        GameOverPanel.SetActive(false);
    }


    void Update()
    {
        //print(SceneInfo.heart);
        if (transform.position.y < -7.52f)
        {
            moveToSpawn();
            SceneInfo.heart--;
            
        }
        if (SceneInfo.heart <= 0)
        {
            HeartImage3.SetActive(false);
            GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        } else if (SceneInfo.heart == 1)
        {
            HeartImage2.SetActive(false);
            HeartImage1.SetActive(false);
            HeartImage3.SetActive(true);
        } else if (SceneInfo.heart == 2)
        {
            HeartImage2.SetActive(true);
            HeartImage1.SetActive(false);
        }
        else if(SceneInfo.heart == 3)
        {
            HeartImage1.SetActive(true);
            HeartImage2.SetActive(true);
            HeartImage3.SetActive(true);
        }


        if(SceneInfo.heart > 3)
        {
            SceneInfo.heart = 3;
        }

        /*if (Heart <= 0)
        {
            //HeartImage3.SetActive(false);
            GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }*/

        coinText.text = SceneInfo.coin.ToString("0");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneInfo.heart--;
            Movement.animator.SetTrigger("hurt");
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            SceneInfo.coin++;
            
        }

        if (collision.gameObject.tag == "Obstacle")
        {

            SceneInfo.heart--;
            Movement.animator.SetTrigger("hurt");
        }

        if (collision.gameObject.tag == "bullet")
        {
            //Movement.animator.SetTrigger("hurt");
            SceneInfo.heart--;
        }

        if (collision.gameObject.tag == "heart")
        {

            SceneInfo.heart++;
        }

        if(collision.gameObject.tag == "newPos")
        {
            playerSpawn.position = newPos.position;
        }
    }

    public void mali()
    {
        SceneInfo.heart--;
        for (int i = 0; i < donnie.Length; i++)
        {
            donnie[i].hurt();
        }
        
    }

    public void retry()
    {

    }


    public void retryGameOverButton()
    {
        //SceneManager.LoadScene(retryScene);
        
        
            GameOverPanel.SetActive(false);
            SceneManager.LoadScene(retryScene);
            SceneInfo.heart = 3;
            SceneInfo.coin = 0;
            Time.timeScale = 1f;
        
        
    }

    public void revive()
    {
        if (SceneInfo.coin >= 20)
        {
            SceneInfo.heart = 3;
            SceneInfo.coin -= 20;
            //transform.position = playerSpawn.position;
            Time.timeScale = 1f;
            GameOverPanel.SetActive(false);
        }
        else
        {
            //notEnough.SetActive(true);
            Debug.Log("not enough coins");
        }
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(retryScene);
        GameOverPanel.SetActive(false);
    }

    public void moveToSpawn()
    {
        transform.position = playerSpawn.position;
    }
}
