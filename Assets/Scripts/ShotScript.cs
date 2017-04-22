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
            other.GetComponent<SpriteRenderer>().color = new Color32(50, 150, 255, 255);
                other.GetComponent<BulletMoveScript>().isSlowed = true;
        }

        
    }
}
