using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    [SerializeField] private GameObject player;
    public float offset;
    public float offsetSmoothing;
    public Transform cameraUpDown;
    private Vector3 playerPosition;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        
        // transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(playerPosition, playerPosition, offsetSmoothing * Time.deltaTime);
        // Camera Bounds
        if (transform.position.y > 2.79f)
        {
            transform.position = new Vector3(player.transform.position.x, 2.79f, transform.position.z);
        }
        else if (transform.position.y < -0.32f)
        {
            transform.position = new Vector3(player.transform.position.x, -0.32f, transform.position.z);
        }

        if (transform.position.x < -4.9f)
        {
            transform.position = new Vector3(-4.9f, -0.32f, transform.position.z);
        }

        
    }
}

