using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public Transform alpha;
    public Transform omega;
    //public Transform Togo;
    public float Mspeed = 3f;
    //public float Pspeed = 5f;

    public float endDestination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, alpha.position, Mspeed * Time.deltaTime);

        if (transform.position.x < endDestination)
        {
            transform.position = new Vector3(omega.position.x, transform.position.y, transform.position.z);
        }


    }


}
