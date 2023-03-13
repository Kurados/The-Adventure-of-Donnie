using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizManager : MonoBehaviour
{
    public Animator anim;

    public GameObject HUD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hideHUD()
    {
        HUD.SetActive(false);
    }

    public void showHUD()
    {
        HUD.SetActive(true);
    }

    public void timerOn()
    {
        battleManager.timerOn = true;
    }
}
