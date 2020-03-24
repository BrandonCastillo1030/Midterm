using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allySpawn : MonoBehaviour
{
       public int numObjects = 10;
       public GameObject prefab;

       void Start() {
           Vector3 center = transform.position;
           for (int i = 0; i < numObjects; i++){
               Vector3 pos = RandomCircle(center, 5.0f);
               Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center);
               Instantiate(prefab, pos, rot);
           }
       }

       Vector3 RandomCircle ( Vector3 center ,   float radius  ){
           float ang = UnityEngine.Random.value * 360;
           Vector3 pos;
           pos.y = 1 + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
           pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
           pos.z = 0;
           return pos;
       }
   }
