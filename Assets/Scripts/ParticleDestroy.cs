using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {

    public float duration;
    public bool constant = false;
    int loop = 0;

	// Use this for initialization
	void Start () {

        StartCoroutine(Wait());
        Wait();

	}

    IEnumerator Wait()
    {
        float x;
        if (constant == false)
        {
            if (loop % 10 == 0)
            {
                x = Random.Range(0f, 2 * duration);
            }
            else if (loop % 5 == 0)
            {
                x = Random.Range(0f, 1.5f * duration);
            }
            else
            {
                x = Random.Range(0f, duration);
            }
        }
        else
        {
            x = duration;
        }
        yield return new WaitForSecondsRealtime(x);
        Destroy(this.gameObject);
    }

}
