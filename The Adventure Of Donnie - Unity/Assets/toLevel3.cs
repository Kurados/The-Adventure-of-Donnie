using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toLevel3 : MonoBehaviour
{
    public GameObject transition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneInfo.lvl_3_clear = true;
        transition.SetActive(true);
    }
}
