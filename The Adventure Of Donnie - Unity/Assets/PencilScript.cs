using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilScript : MonoBehaviour
{

    public float pencilSpeed = 2f;
    private Rigidbody2D pencilRB;
    //public GameObject pencilEffect;


    // Start is called before the first frame update
    void Start()
    {
        pencilRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pencilRB.velocity = new Vector2(pencilSpeed * transform.localScale.x, 0f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monster" || collision.gameObject.layer == 6)
        {
            //Instantiate(pencilEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster" || collision.gameObject.layer == 6)
        {

            //Instantiate(pencilEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }*/


}
