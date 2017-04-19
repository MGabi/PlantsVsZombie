using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject prefab;
    public float interval;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

    // Update is called once per frame
    void Spawn()
    {

        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
