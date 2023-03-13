using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    public float fireballSpeed = 10f;

    private Rigidbody2D fireballRB;

    public GameObject fbEffect;

    public bool up = false;
    public bool down = false;  

    // Start is called before the first frame update
    void Start()
    {
        fireballRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!up)
        {
            fireballRB.velocity = new Vector2(fireballSpeed * transform.localScale.x, 0f);
        }
        else 
        {
            fireballRB.velocity = new Vector2(0f, fireballSpeed * transform.localScale.y);
        }
        
        Destroy(gameObject, 5f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "ground")
        {
            Instantiate(fbEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }

    }
}
