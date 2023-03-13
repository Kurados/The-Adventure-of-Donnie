using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasAssetScript : MonoBehaviour
{
    public GameObject PausedPanel;
    public string retryScene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PausedButton()
    {
        PausedPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        PausedPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Retry()
    {
        
        SceneManager.LoadScene(retryScene);
        SceneInfo.heart = 3;
        SceneInfo.coin = 0;
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        Debug.Log("Menu");
    }

    

}
