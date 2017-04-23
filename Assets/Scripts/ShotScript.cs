using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

    public float damage;
    public bool doSlow = false;
    public bool destroyable = true;
    public string plant;

    private void Start()
    {
        GetPlantType();
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.GetComponent<HealthScript>() != null)
        if(other.GetComponent<HealthScript>().isEnemy)
        {
            if(destroyable == true)
                Destroy(this.gameObject);
            if(plant.Equals("ExplodePlant"))
                other.GetComponent<HealthScript>().DoDamage(other.GetComponent<HealthScript>().health);
            else
                other.GetComponent<HealthScript>().DoDamage(damage);
            if (doSlow)
                {
                    other.GetComponent<SpriteRenderer>().color = new Color32(50, 150, 255, 255);
                    other.GetComponent<BulletMoveScript>().isSlowed = true;
                }
        }

        
    }

    private void GetPlantType()
    {
        if(plant.Equals("ShooterFlower"))
        {
            damage = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_DMG_SHOOTER));
            destroyable = true;
            doSlow = false;
        }
        else if(plant.Equals("FreezeFlower"))
        {
            damage = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_DMG_FREEZE));
            destroyable = true;
            doSlow = true;
        }
        else if(plant.Equals("MineFlower"))
        {
            damage = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_DMG_BOMB));
            destroyable = true;
            doSlow = false;
        }
        else if(plant.Equals("ExplodePlant"))
        {
            destroyable = false;
            doSlow = false;
        }
    }
}
