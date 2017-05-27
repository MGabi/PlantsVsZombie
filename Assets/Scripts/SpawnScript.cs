using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject prefab;
    public float interval;
    float interval2;
    public string plant;
    // Use this for initialization
    void Start()
    {
        interval2 = interval;
    }

   
    private void Update()
    {
        if (interval2 <= 0)
        {
            if (plant.Equals("Sunflower"))
                Spawn();
            else
            {
                if (GlobalVariables.ExistsZombie(plant,this.transform))
                    Spawn();
            }
            interval2 = interval;
        }
        else
            interval2 -= Time.deltaTime;
    }
    // Update is called once per frame
    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
