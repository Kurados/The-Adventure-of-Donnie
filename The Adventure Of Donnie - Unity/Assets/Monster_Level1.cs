using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Level1 : MonoBehaviour
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
    public float X;

    //public battle_Enemy b_Enemy;

    public static bool _hurt;
    public static bool _dead;

    public GameObject _battleManager;

    public GameObject nextMonster;

    public bool HasDrop;
    public GameObject heart;
    public Transform point;

    void Start()
    {
        currentLife = monsterLife;
        transform.position = Mpoints[MstartingPoint].position;
        healthbar.SetMaxHealth(monsterLife);
        moveCount = transform.position.x;
    }

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

        if (currentLife <= 0)
        {
            battleManager.timerOn = false;
            _dead = true;
            nextMonster.SetActive(true);
            Destroy(gameObject, 0.6f);
            Time.timeScale = 1f;
            if (HasDrop)
            {
                heart.SetActive(true);
            }
            
        }

        if (GameManager.hitEnemy == true)
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
        if (transform.hasChanged)
        {
            if (transform.position.x < moveCount)
            {

                moveCount = transform.position.x;

                Vector3 localScale = transform.localScale;
                localScale.x = -X;
                transform.localScale = localScale;

            }

            else if (transform.position.x > moveCount)
            {

                moveCount = transform.position.x;

                Vector3 localScale = transform.localScale;
                localScale.x = X;
                transform.localScale = localScale;
            }


            transform.hasChanged = false;
        }
    }
    public void damage()
    {

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _battleManager.SetActive(true);
            battleManager.playerDetected = true;
            Debug.Log("tumama");
            hasPatrol = false;
        }
    }
}
