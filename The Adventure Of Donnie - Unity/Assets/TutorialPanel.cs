using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPanel : MonoBehaviour
{
    public GameObject _1;
    public GameObject _2;
    public GameObject _3;
    public GameObject _4;
    public GameObject _5;
    public GameObject tutPanel;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject texts;
    public PlayerMovement movement;
    //public bool onGoing = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _1.SetActive(true);
        Time.timeScale = 0f;
        //movement.speed = 0f;
        //movement.jumpSpeed = 0f;
        //movement.stop();
    }

    // Update is called once per frame
    void Update()
    {
        movement.animator.SetBool("jump", false);
    }

    public void next1()
    {
        _1.SetActive(false);
        _2.SetActive(true);
    }
    public void next2()
    {
        _2.SetActive(false);
        _3.SetActive(true);
    }
    public void next3()
    {
        _3.SetActive(false);
        _4.SetActive(true);
    }
    public void next4()
    {
        _4.SetActive(false);
        _5.SetActive(true);
    }

    public void mayoNa()
    {
        //onGoing = false;
        //movement.speed = 6f;
        //.jumpSpeed = 9f;
        //next_1.SetActive(false);
        tutPanel.SetActive(false);
        Time.timeScale = 1f;
        cam1.SetActive(true);
        cam2.SetActive(false);
        texts.SetActive(true);
        
    }
}
