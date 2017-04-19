using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public int health;
    public bool isEnemy;

	public void DoDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
            Destroy(this.gameObject);
    }
}
