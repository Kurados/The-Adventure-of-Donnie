using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter_script : MonoBehaviour
{

    public GameObject bullet;
    public Transform throwPoint;
    public float fireRate = 0.5f;
    private float nextFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fire();
    }

    public void fire()
    {
        if (Time.time > nextFire)
        {

            
            //near.SetActive(true);
            nextFire = Time.time + fireRate;
            /*GameObject bulletClone = (GameObject)*/Instantiate(bullet, throwPoint.position, throwPoint.rotation);
            //bulletClone.transform.localScale = transform.localScale;
        }
    }
}
