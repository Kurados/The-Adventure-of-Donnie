using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sojubridge1 : MonoBehaviour
{

    public GameObject MathPanel;
    public GameObject MathPanelBG;
    public GameObject tulayTrigger;
    public GameObject tulay;
    private bool mali = false;

    public float nextspawn = 2f, spawn;

    private void Start()
    {

    }
    private void Update()
    {

    }
    public void wrong()
    {
        mali = true;
        hideBridge();
    }

    void hideBridge()
    {
        Time.timeScale = 1f;
        tulay.SetActive(false);
        MathPanel.SetActive(false);
        MathPanelBG.SetActive(false);
        tulayTrigger.SetActive(false);
        Debug.Log("mali bool value =" + mali);
    }

    void showBridge()
    {
        Time.timeScale = 1f;
        tulay.SetActive(true);
        tulayTrigger.SetActive(true);
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Donnie collide to show bridge");
            showBridge();
        }
    }


}
