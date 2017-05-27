using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlants_Buy : MonoBehaviour {

    public GameObject pref1;
    public GameObject pref2;
    public GameObject pref3;
    public GameObject pref4;
    public GameObject pref5;
    public GameObject pref6;
    public GameObject panel;
    public GameObject shovel;

    private int i = 8, j = 0;
    void Start () {

        
	    if (Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_SUN)))
        {
            Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
            Instantiate(pref1, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
        if (Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_SHOOTER)))
        {
            Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
            Instantiate(pref2, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
        if (Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_BOMB)))
        {
            Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
            Instantiate(pref3, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
        if (Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_WALL)))
        {
            Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
            Instantiate(pref4, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
        if (Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_FREEZE)))
        {
            Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
            Instantiate(pref5, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }
        if (Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_EXPLODE)))
        {
            Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
            Instantiate(pref6, new Vector3(j, i, 0), Quaternion.identity);
            j++;
        }

        Instantiate(panel, new Vector3(j, i, 0), Quaternion.identity);
        Instantiate(shovel, new Vector3(j, i, 0), Quaternion.identity);
    }
	
}
