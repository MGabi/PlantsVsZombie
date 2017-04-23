using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosionScript : MonoBehaviour {

    public GameObject particle;
    float time = 1.5f;
    public int damage = 5;
    Vector3 poz;
    int loop = 0;
	// Use this for initialization
	public void Explode () {
        {
            poz.x = this.transform.position.x;
            poz.y = this.transform.position.y;
            poz.z = this.transform.position.z;

            this.transform.position = new Vector3(-20, -20, -20);
            StartCoroutine(Explosion());
            Explosion();
        }
	}

    IEnumerator Explosion()
    {
        time -= 0.07f;
        float x, y;
        if (loop % 10 == 0)
        {
            x = Random.Range(-0.7f, 0.7f);
            y = Random.Range(-0.7f, 0.7f);
        }
        else if (loop % 5 == 0)
        {
            x = Random.Range(-0.5f, 0.5f);
            y = Random.Range(-0.5f, 0.5f);
        }
        else
        {
             x = Random.Range(-0.3f, 0.3f);
             y = Random.Range(-0.3f, 0.3f);
        }
        loop++;
        Instantiate(particle, new Vector3(poz.x +x, poz.y + y, poz.z), Quaternion.identity);
        yield return new WaitForSeconds(0.07f);
        if (time > 0)
            StartCoroutine(Explosion());
        else
        {
            Destroy(this.gameObject);
        }
    }

   
}
