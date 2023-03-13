using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public Transform playerTrasnform;
    //public Transform Togo;
    public float Mspeed = 3f;
    //public float Pspeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTrasnform.position, Mspeed * Time.deltaTime);
       // transform.position = Vector2.MoveTowards(transform.position, Togo.position, Pspeed * Time.deltaTime);


        /*if (transform.position.y > 1.2f)
        {
            transform.position = new Vector3(transform.position.x, 1.2f, transform.position.z);
        }
        else if (transform.position.y < -0.53f)
        {
            transform.position = new Vector3(transform.position.x, -0.53f, transform.position.z);
        }*/

        if (transform.position.x < -13.82)
        {
            transform.position = new Vector3(11.63f, transform.position.y, transform.position.z);
        }


    }


}
