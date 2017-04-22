using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Wait());
        Wait();
	}

    IEnumerator Wait()
    {
        float x = Random.Range(0f, 2.5f);
        yield return new WaitForSecondsRealtime(x);
        Destroy(this.gameObject);
    }

}
