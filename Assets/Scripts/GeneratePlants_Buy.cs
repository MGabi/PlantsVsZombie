using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlants_Buy : MonoBehaviour {

    public GameObject pref1;
    public GameObject pref2;
    private int i = 5, j = -1;
    void Start () {
	    if(pref1 != null)
        {
            Instantiate(pref1, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
        if(pref2 != null)
        {
            Instantiate(pref2, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
	}
	
}
