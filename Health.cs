﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float explosionDuration = 1f;
    [SerializeField] GameObject deathVFX;

    public void GetDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
            
        }

        
    }
    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
       GameObject explosion = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(explosion, explosionDuration);
    }
}
