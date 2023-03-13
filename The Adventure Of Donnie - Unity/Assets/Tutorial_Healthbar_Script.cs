using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Healthbar_Script : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int monsterLife)
    {
        slider.maxValue = monsterLife;
        slider.value = monsterLife;
    }

    public void SetHealth(int monsterLife)
    {
        slider.value = monsterLife;
    }
}
