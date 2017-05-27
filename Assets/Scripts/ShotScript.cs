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
     
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.GetComponent<HealthScript>() != null)
        if(other.GetComponent<HealthScript>().isEnemy)
        {
            if(destroyable == true)
                Destroy(this.gameObject);
            other.GetComponent<HealthScript>().DoDamage(damage);
            if (doSlow)
                {
                    other.GetComponent<SpriteRenderer>().color = new Color32(50, 150, 255, 255);
                    other.GetComponent<BulletMoveScript>().isSlowed = true;
                }
        }

        
    }

    
    
}
