using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ally;
    void Start()
    {

        for (int i = 0; i < 20; i++)
        {
            Instantiate(ally, new Vector3(UnityEngine.Random.Range(-30, 30), 3, i), Quaternion.identity);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
