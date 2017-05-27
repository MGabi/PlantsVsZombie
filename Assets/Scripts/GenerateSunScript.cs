﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSunScript : MonoBehaviour {

    public GameObject prefab;

    public void Start()
    {
        InvokeRepeating("Spawn", 15, 15);
    }
        
    


    void Spawn()
    {
        int x = Random.Range(1, 9);
        Instantiate(prefab, new Vector3(x,5, 0), Quaternion.identity);
    }
}
