using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allySpawn : MonoBehaviour
{
    public int z;
    public int maximumZ =5;
    // Start is called before the first frame update
    public GameObject ally;
    void Start()
    {

        for (int i = 0; i < 20; i+=1)
        {
            if (i < 20)
            {
                z = z + 1;
            }
            if (z > 10)
            {
                z = maximumZ;
            }

            Instantiate(ally, new Vector3(UnityEngine.Random.Range(5, 16), 1, z), Quaternion.identity);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
