using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAtackScript : MonoBehaviour {

    public int dmg;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<HealthScript>() != null)
            if (collision.collider.GetComponent<HealthScript>().isEnemy == false)
            {
                collision.collider.GetComponent<HealthScript>().DoDamage(dmg);
            }
        
        this.transform.position = new Vector3(this.transform.position.x + 0.5f, this.transform.position.y, this.transform.position.z);
    }
}
