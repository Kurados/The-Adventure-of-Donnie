using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outro : MonoBehaviour
{
    public GameObject  Intro;
    public GameObject videoPlayer;


    //public AudioMixer SFXMixer;

    // Start is called before the first frame update
    void Start()
    {
        SceneInfo.coin = 0;
        Tutorial();

        SceneInfo.lvl_1_clear = true;
        SceneInfo.lvl_2_clear = true;
        SceneInfo.lvl_3_clear = true;
        SceneInfo.lvl_4_clear = true;

    }

    // Update is called once per frame
    void Update()
    {

       

    }


    public void Tutorial()
    {

        //iTime = Time.time + timeAppear;
        Intro.SetActive(true);
        videoPlayer.SetActive(true);
        //StartCoroutine(Appear(70, ContinueButton, videoPlayer, Skip));
        StartCoroutine(toTutorial());

    }

    IEnumerator toTutorial()
    {
        yield return new WaitForSeconds(99);
        SceneManager.LoadScene("MainMenu");
        //Time.timeScale = 1f;
    }


}
