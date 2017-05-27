using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public GameObject damageSparkle;
    public RuntimeAnimatorController dieAnimation;
    public float health;
    public bool isEnemy;
    public string plant;
    public RuntimeAnimatorController animation;
    private RuntimeAnimatorController anim2;
    private void Start()
    {
        if(isEnemy == true)
        {
            this.GetComponent<Animator>().enabled = true;
        }
        else
        {
            if(animation!=null)
            {
                anim2 = this.GetComponent<Animator>().runtimeAnimatorController;
                this.GetComponent<Animator>().runtimeAnimatorController = animation;
                StartCoroutine(ChangeAnim(anim2));
               
            }
        }
       
        GetFlowerType();
        if (this.GetComponent<Animator>() != null)
            this.GetComponent<Animator>().speed = 0.5f;
    }

    IEnumerator ChangeAnim(RuntimeAnimatorController anim)
    {
        this.GetComponent<Animator>().runtimeAnimatorController = anim;
        yield return new WaitForSeconds(2);
        

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
                this.GetComponent<Animator>().enabled = true;
                this.GetComponent<MineExplosionScript>().Explode();
            }
            else
            {
                if (isEnemy == true)
                {
                    GlobalVariables.score += 50;
                   
                    GlobalVariables.ZombieOnLane[(int)(this.transform.position.y+0.2)]--;
                   
                }
                StartCoroutine(DestroyZombie());
            }
            
        }
        else
            Instantiate(damageSparkle, this.transform.position, Quaternion.identity);
    }

    IEnumerator DestroyZombie()
    {
        this.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
