using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnemy_Level1 : MonoBehaviour
{
    public Animator battle_enemy_anim;
    public static bool isDead;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Monster_Level1._hurt == true)
        {
            battle_enemy_anim.SetTrigger("hurt");
            Monster_Level1._hurt = false;
        }
        if (Monster_Level1._dead == true)
        {
            battle_enemy_anim.SetTrigger("dead");
            Monster_Level1._dead = false;
        }
        if(battleManager.attack == true)
        {
            battle_enemy_anim.SetTrigger("attack");
            battleManager.attack = false;
        }

        //print(isDead);
    }

    public void hurt()
    {
        battle_enemy_anim.SetTrigger("hurt");
    }

    public void dead()
    {
        battle_enemy_anim.SetTrigger("dead");
    }

    
    public void deadFunc()
    {
        isDead = true;
    }


}
