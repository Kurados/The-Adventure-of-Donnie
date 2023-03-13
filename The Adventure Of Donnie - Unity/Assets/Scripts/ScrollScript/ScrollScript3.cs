using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript2 : MonoBehaviour
{
    public GameObject MathPanel;
    public GameObject MathPanelBG;
    public GameObject scrollPointImage;

    //public int scrollPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        scrollPointImage.SetActive(true);
       // scrollPoint++;
        Destroy(gameObject);

    }


}
