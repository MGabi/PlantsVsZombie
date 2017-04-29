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
        GetPlantType();

       
    }

    private void GetPlantType()
    {
        if(plant.Equals("Sunflower"))
        {
            interval = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_SUN_COOLDOWN));
        }
        else if(plant.Equals("ShooterFlower"))
        {
            Debug.Log("asd: " + PlayerPrefs.GetString(HelperClass.PREF_SPEED_SHOOTER));
            interval = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_SPEED_SHOOTER));
            Debug.Log(interval);
            Debug.Log(interval.ToString());
        }
        else if(plant.Equals("FreezeFlower"))
        {
            interval = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_SPEED_FREEZE));
        }

        
    }

    private void Update()
    {
        if (interval2 <= 0)
        {
            if (plant.Equals("Sunflower"))
                Spawn();
            else
            {
                if (GlobalVariables.ZombieOnLane[(int)this.transform.position.y] > 0)
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
