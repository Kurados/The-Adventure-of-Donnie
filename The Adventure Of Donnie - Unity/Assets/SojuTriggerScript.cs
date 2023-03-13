using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SojuTriggerScript : MonoBehaviour
{


public class TriggerScript : MonoBehaviour
{

    public GameObject _sojuTulay;
    public GameObject MathPanel;
    public GameObject MathPanelBG;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MathPanel.SetActive(true);
            MathPanelBG.SetActive(true);
            Time.timeScale = 0f;

        }
    }

    public void tama()
    {
        Time.timeScale = 1f;
        MathPanel.SetActive(false);
        MathPanelBG.SetActive(false);
        Destroy(gameObject);
        Destroy(_sojuTulay);    

    }
}

}
