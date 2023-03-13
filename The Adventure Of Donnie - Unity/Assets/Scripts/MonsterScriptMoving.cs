using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScriptMoving : MonoBehaviour
{
    [SerializeField] private float Mspeed;
    public int MstartingPoint;
    public Transform[] Mpoints;
    public int monsterLife = 10;
    public int currentLife;

    public Tutorial_Healthbar_Script healthbar;

    private int i;

    public bool hasPatrol;

    private float moveCount;
    //private float datiLang;
    //private bool isFacingRight = true;
    public float X;

    public battle_Enemy b_Enemy;

    public static bool _hurt;
    public static bool _dead;
    //private bool FacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = monsterLife;
        transform.position = Mpoints[MstartingPoint].position;
        healthbar.SetMaxHealth(monsterLife);
        moveCount = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        moveFlip();
        if (hasPatrol)
        {
            if (Vector2.Distance(transform.position, Mpoints[i].position) < 0.02f)
            {
                i++;
                if (i == Mpoints.Length)
                {
                    i = 0;
                }
            }

            transform.position = Vector2.MoveTowards(transform.position, Mpoints[i].position, Mspeed * Time.deltaTime);
        }

        if(currentLife <= 0)
        {
            forTheMeantime.timerOn = false;
            _dead = true;
            Destroy(gameObject, 0.6f);
            Time.timeScale = 1f;
        }

        if (GameManager.hitEnemy)
        {
            _hurt = true;
            currentLife--;
            healthbar.SetHealth(currentLife);
            Debug.Log(currentLife);
            GameManager.hitEnemy = false;
        }
    }

    private void moveFlip()
    {
        //Debug.Log(transform.position.x);
        if (transform.hasChanged)
        {
            if (transform.position.x < moveCount)
            {
                //Debug.Log("Decreased!");
                //Update lastXVal
                moveCount = transform.position.x;

                Vector3 localScale = transform.localScale;
                localScale.x = -X;
                transform.localScale = localScale;

            }

            else if (transform.position.x > moveCount)
            {
                //Debug.Log("Increased");

                //Update lastXVal
                moveCount = transform.position.x;

                Vector3 localScale = transform.localScale;
                localScale.x = X;
                transform.localScale = localScale;
            }
            /*else if(transform.position.x)
            {
                Debug.Log("idle");
            }*/

            transform.hasChanged = false;
        }
    }
    public void damage()
    {
        //b_Enemy.hurt();
        //wew.haha();
        _hurt = true;
        currentLife--;
        healthbar.SetHealth(currentLife);
        Debug.Log(currentLife);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            forTheMeantime.playerDetected = true;
            Debug.Log("tumama");
        }
    }
}