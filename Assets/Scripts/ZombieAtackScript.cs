using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAtackScript : MonoBehaviour {

    public float dmg;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<HealthScript>() != null)
            if (collision.collider.GetComponent<HealthScript>().isEnemy == false)
            {
                collision.collider.GetComponent<HealthScript>().DoDamage(dmg);
                if(collision.collider.GetComponent<MineExplosionScript>() != null)
                {
                    StartCoroutine(Burn(collision));
                }
           
                else if(collision.collider.GetComponent<HealthScript>().health > 0 )
                {
                    this.transform.position = new Vector3(this.transform.position.x + 0.01f, this.transform.position.y, this.transform.position.z);
                    this.GetComponent<BulletMoveScript>().speed = 0;
                    StartCoroutine(Wait());
                    Wait();
                }
                else
                {
                    this.GetComponent<BulletMoveScript>().speed = this.GetComponent<BulletMoveScript>().speed2;
                }
                
            }
  
    }

    IEnumerator Burn(Collision2D collision)
    {
        yield return new WaitForSeconds(1);
        this.GetComponent<HealthScript>().DoDamage(collision.collider.GetComponent<MineExplosionScript>().damage);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(3);
        this.GetComponent<BulletMoveScript>().speed = this.GetComponent<BulletMoveScript>().speed2;
    }
}
