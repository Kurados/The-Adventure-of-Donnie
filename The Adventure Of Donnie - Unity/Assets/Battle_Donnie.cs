using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_Donnie : MonoBehaviour
{
    public Animator battleDonnieAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hurt()
    {
        battleDonnieAnimator.SetTrigger("hurtBattle");
    }
}
