﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {

        for (int i = 0; i < 50; i++)
        {
            Instantiate(enemy, new Vector3(UnityEngine.Random.Range(-20, 20), 3, i), Quaternion.identity);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}