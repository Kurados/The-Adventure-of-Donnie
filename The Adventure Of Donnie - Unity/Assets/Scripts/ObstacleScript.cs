using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            time = Time.deltaTime + 10f;
            gameObject.GetComponent<Collider>().enabled = false;
            //yield return new WaitForSeconds(2);

        if (time < Time.deltaTime)
        {
            gameObject.GetComponent<Collider>().enabled = true;

            //gameObject.GetComponent<>
        }

            
        }
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            time = Time.deltaTime + 10f;
            gameObject.GetComponent<Collider>().enabled = false;

            if (time < Time.deltaTime)
            {
                gameObject.GetComponent<Collider>().enabled = true;
            }
        }
    }*/


}
