using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public GameObject damageSparkle;
    public float health;
    public bool isEnemy;
    public string plant;

    private void Start()
    {
        GetFlowerType();
        if (this.GetComponent<Animator>() != null)
            this.GetComponent<Animator>().speed = 0.5f;
    }


    private void GetFlowerType()
    {
        if (plant.Equals("Sunflower"))
        {
            health = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_HEALTH_SUN));
            isEnemy = false;
        }
        else if (plant.Equals("ShooterFlower"))
        {
            health = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_HEALTH_SHOOTER));
            isEnemy = false;
        }
        else if (plant.Equals("WallnutFlower"))
        {
            health = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_HEALTH_WALL));
            isEnemy = false;
        }
        else if (plant.Equals("FreezeFlower"))
        {
            health = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_HEALTH_FREEZE));
            isEnemy = false;
        }
       
        

    }

    public void DoDamage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            if(this.GetComponent<MineExplosionScript>() != null)
            {
                this.GetComponent<MineExplosionScript>().Explode();
            }
            else
            {
                Destroy(this.gameObject);
            }
            if(isEnemy == true)
                GlobalVariables.score += 50;
        }
        else
            Instantiate(damageSparkle, this.transform.position, Quaternion.identity);
    }
}
