﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public int health;
    public bool isEnemy;
   

    private void Start()
    {
        if(this.GetComponent<Animator>() != null)
            this.GetComponent<Animator>().speed = 0.5f;
    }

    public void DoDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Destroy(this.gameObject);
            if(isEnemy == true)
                GlobalVariables.score += 50;
        }
    }
}
