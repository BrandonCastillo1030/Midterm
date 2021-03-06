﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetR : MonoBehaviour
{
    public float health = 1f;

    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag=="Player")
      {
        health -= 1f;
        if (health <= 0f)
        {
            Die();
        }
      }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
