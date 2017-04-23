using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {

    public float duration;

	// Use this for initialization
	void Start () {
        StartCoroutine(Wait());
        Wait();
	}

    IEnumerator Wait()
    {
        float x = Random.Range(0f, duration);
        yield return new WaitForSecondsRealtime(x);
        Destroy(this.gameObject);
    }

}
