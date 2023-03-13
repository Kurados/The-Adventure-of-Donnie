using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenuScript : MonoBehaviour
{
    public GameObject LevelScreen, Intro;
    public GameObject videoPlayer;
    public GameObject ContinueButton;
    public GameObject Skip;
    public GameObject setting;

    public GameObject lock_1;
    public GameObject lock_2;
    public GameObject lock_3;
    public GameObject lock_4;

    public bool isPlayerStarted = false;

    private float iTime;
    private float timeAppear = 10f;

    public GameObject sound;

    
    //public AudioMixer SFXMixer;

    // Start is called before the first frame update
    void Start()
    {
        SceneInfo.coin = 0;
        sound.SetActive(true);
        //ContinueButton.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        Lock_Func();


    }

    public void Lock_Func()
    {
        if (SceneInfo.lvl_1_clear == true)
        {
            lock_1.SetActive(false);
        }
        else
        {
            lock_1.SetActive(true);
        }

        if (SceneInfo.lvl_2_clear == true)
        {
            lock_2.SetActive(false);
        }
        else
        {
            lock_2.SetActive(true);
        }

        if (SceneInfo.lvl_3_clear == true)
        {
            lock_3.SetActive(false);
        }
        else
        {
            lock_3.SetActive(true);
        }

        if (SceneInfo.lvl_4_clear == true)
        {
            lock_4.SetActive(false);
        }
        else
        {
            lock_4.SetActive(true);
        }
    }

    public void Load_Level()
    {
        LevelScreen.SetActive(true);
    }

    public void back()
    {
        LevelScreen.SetActive(false);
        setting.SetActive(false);
    }

    public void Tutorial()
    {
        sound.SetActive(false);
        iTime = Time.time + timeAppear;
        Intro.SetActive(true);
        videoPlayer.SetActive(true);
        //StartCoroutine(Appear(70, ContinueButton, videoPlayer, Skip));
        StartCoroutine(toTutorial());
 
    }

    public void Level_1()
    {
        SceneManager.LoadScene("MainGame");
        SceneInfo.heart = 3;
        SceneInfo.coin = 0;
        Time.timeScale = 1f;
    }
    public void Level_2()
    {
        SceneManager.LoadScene("Level_2");
        SceneInfo.heart = 3;
        SceneInfo.coin = 0;
        Time.timeScale = 1f;
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Level_3");
        SceneInfo.heart = 3;
        SceneInfo.coin = 0;
        Time.timeScale = 1f;
    }
    public void Level_4()
    {
        SceneManager.LoadScene("Level_4");
        SceneInfo.heart = 3;
        SceneInfo.coin = 0;
        Time.timeScale = 1f;
    }


    IEnumerator toTutorial()
    {
        yield return new WaitForSeconds(56);
        SceneManager.LoadScene("Tutorial");
        //Time.timeScale = 1f;
    }

    /*IEnumerator Appear(int seconds, GameObject ContinueButton, GameObject videoPlayer, GameObject Skip)
    {
        yield return new WaitForSeconds(seconds);
        ContinueButton.SetActive(true);
        videoPlayer.SetActive(false);
        Skip.SetActive(false);
    }*/

    public void Continue()
    {
        SceneManager.LoadScene("Tutorial");
        Time.timeScale = 1f;
    }

    public void skip()
    {
        SceneManager.LoadScene("Tutorial");
        //Time.timeScale = 1f;
    }

    public void quit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        setting.SetActive(true);
    }

    

}
