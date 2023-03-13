using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static AudioClip coinPickUp, Jumping;
    private static AudioSource Sound;


    // Start is called before the first frame update
    void Start()
    {
        coinPickUp = Resources.Load<AudioClip>("coinPickup01");
        Jumping = Resources.Load<AudioClip>("jumping01");

        Sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "coinPickup01":
                Sound.PlayOneShot(coinPickUp);
                break;
            case "jumping01":
                Sound.PlayOneShot(Jumping);
                break;
        }
    }
}
