using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject delete;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        delete.SetActive(false);
        if (collision.gameObject.tag == "trigger")
        {
            Destroy(delete);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        delete.SetActive(false);
        if (collision.gameObject.tag == "trigger")
        {
            Destroy(delete);
           

        }
    }

    
}
