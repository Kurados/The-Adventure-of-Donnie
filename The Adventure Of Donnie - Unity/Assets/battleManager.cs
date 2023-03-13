using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class battleManager : MonoBehaviour
{
    public GameObject[] obstacle;
    public bool hasObstacle;


    public GameObject quiz;
    public PlayerMovement _movement;
    public TMP_Text timer;
    public float time = 10.2f;
    private float reservedtime;

    public static bool timerOn;
    public playerScript player;

    public GameObject winPanel;
    public GameObject currentEnemy;

    public static bool playerDetected;

    public float timeMinus;

    public static bool attack;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = false;
        reservedtime = time;
        quiz.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (hasObstacle)
        {
            for (int i = 0; i < obstacle.Length; i++)
            {
                obstacle[i].SetActive(true);
            }
        }

        if (timerOn)
        {
            _timer();
        }

        if (time <= 0)
        {
            player.mali();
            time = reservedtime;
            attack = true;
            
        }

        if (BattleEnemy_Level1.isDead == true)
        {
            _movement.speed = 5f;
            currentEnemy.SetActive(false);
            winPanel.SetActive(true);
            BattleEnemy_Level1.isDead = false;
            //quiz.SetActive(false);
        }

        if (playerDetected)
        {
            _movement.speed = 0f;
            playerDetected = false;
        }

        if (GameManager.bawasOras == true)
        {
            time -= timeMinus;
            GameManager.bawasOras = false;
        }

    }
    public void _timer()
        {
            time -= Time.deltaTime;
            timer.text = time.ToString("0:00");
        }

    public void isWinner()
    {
        quiz.SetActive(false);
        timerOn = false;
        //Destroy(quiz);
        Destroy(gameObject);
    }

}
