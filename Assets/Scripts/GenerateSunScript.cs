using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSunScript : MonoBehaviour {

    public GameObject prefab;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", 10, 10);

    }

    void Spawn()
    {
        int x = Random.Range(1, 9);
        Instantiate(prefab, new Vector3(x,-3, 0), Quaternion.identity);
    }
}
