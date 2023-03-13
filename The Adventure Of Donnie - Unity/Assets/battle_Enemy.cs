using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle_Enemy : MonoBehaviour
{

    public Animator battle_enemy_anim;
    public static bool isDead;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(MonsterScriptMoving._hurt == true)
        {
            battle_enemy_anim.SetTrigger("hurt");
            MonsterScriptMoving._hurt = false;
        }
        if(MonsterScriptMoving._dead == true)
        {
            battle_enemy_anim.SetTrigger("dead");
            MonsterScriptMoving._dead = false;
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
