using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinePlantGrow : MonoBehaviour {

    public GameObject pref1;

	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
	}
	
	IEnumerator spawn()
    {
        yield return new WaitForSeconds(5);
        Instantiate(pref1, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        
    }
}
