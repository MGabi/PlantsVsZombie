using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour {

    public GameObject pref1;
    // Use this for initialization
    int i = 0;
    private void Start()
    {
        if(i<5)
        InvokeRepeating("Spawn", GlobalVariables.ZombieMatrix[i][1], GlobalVariables.ZombieMatrix[i][1]);
    }


    void Spawn()
    {
            Instantiate(pref1, new Vector3(9, GlobalVariables.ZombieMatrix[i][0], 0), Quaternion.identity);
        i++;
    }
	
	
}
