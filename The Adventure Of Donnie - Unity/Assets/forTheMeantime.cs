using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class forTheMeantime : MonoBehaviour
{

    public GameObject quiz;
    public GameObject quiz_tutorial;

    public PlayerMovement _movement;

    public GameObject inot;
    public GameObject from;
    public GameObject next_1;
    public GameObject next_2;
    public GameObject next_3;
    public GameObject ready;
    public GameObject rem;
    public GameObject tip;

    public GameObject plat1;
    public GameObject plat2;
    public GameObject plat3;
    public GameObject fairy;

    public TMP_Text timer;
    public float time = 10.2f;

    public static bool timerOn;
    public playerScript player;
    public MonsterScriptMoving enemy;

    public battle_Enemy benemy;

    public GameObject winPanel;
    public GameObject currentEnemy;

    public static bool playerDetected;

    public float timeMinus;

    public GameObject HUD;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            _timer();
        }

        if(time <= 0)
        {
            player.mali();
            time = 10.2f;
        }

        if(enemy.currentLife <= 0)
        {
            fairy.SetActive(true);
            plat1.SetActive(true);
            plat2.SetActive(true);
            plat3.SetActive(true);
            timerOn = false;
            
            
            //Time.timeScale = 1f;
        }

        if(battle_Enemy.isDead == true)
        {
            _movement.speed = 5f;
            currentEnemy.SetActive(false);
            winPanel.SetActive(true);
            battle_Enemy.isDead = false;
            //quiz.SetActive(false);
        }

        if (playerDetected)
        {
            HUD.SetActive(false);
            enemy.hasPatrol = false;
            quiz.SetActive(true);
            quiz_tutorial.SetActive(true);
            _movement.speed = 0f;
            playerDetected = false;
        }

        if(GameManager.bawasOras == true)
        {
            time -= timeMinus;
            GameManager.bawasOras = false;
        }
    }
    

    public void isWinner()
    {
        quiz.SetActive(false);
    }

    public void iniMuna()
    {
        inot.SetActive(false);
        from.SetActive(true);
    }

    public void _1()
    {
        from.SetActive(false);
        next_1.SetActive(true);
    }
    public void _2()
    {
        next_2.SetActive(true);
        next_1.SetActive(false);
    }
    public void _3()
    {
        next_3.SetActive(true);
        next_2.SetActive(false);
    }
    public void Ready()
    {
        tip.SetActive(true);
        rem.SetActive(false);
    }

    public void paaala()
    {
        next_3.SetActive(false);
        rem.SetActive(true);
    }

    public void tips()
    {
        tip.SetActive(false);
        ready.SetActive(true);
    }

    public void taposNa()
    {
        
    }

    public void end()
    {
        
       
    }

    public void endNa()
    {
        HUD.SetActive(true);
        timerOn = true;
        Time.timeScale = 1f;
        ready.SetActive(false);
        quiz_tutorial.SetActive(false);
        //print("end");
    }

    public void _timer()
    {
        time -= Time.deltaTime;
        timer.text = time.ToString("0:00");
    }
    
    public void timeRetry()
    {

    }

    /*public void timerBawas()
    {
        time -= 1f;
    }*/

}
