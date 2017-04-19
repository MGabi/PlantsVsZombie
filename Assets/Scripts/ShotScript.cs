using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

    public int damage;
  
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.GetComponent<HealthScript>() != null)
        if(other.GetComponent<HealthScript>().isEnemy)
        {
            Destroy(this.gameObject);
            other.GetComponent<HealthScript>().DoDamage(damage);
            GlobalVariables.score += 50;
        }

        
    }
}
