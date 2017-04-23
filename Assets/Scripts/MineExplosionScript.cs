using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosionScript : MonoBehaviour {

    public GameObject particle;
    float time = 1.5f;
    public int damage = 5;
    Vector3 poz;
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
        time -= 0.01f;
        float x = Random.Range(-0.5f, 0.5f);
        float y = Random.Range(-0.5f, 0.5f);
        Instantiate(particle, new Vector3(poz.x +x, poz.y + y, poz.z), Quaternion.identity);
        yield return new WaitForSeconds(0.01f);
        if (time > 0)
            StartCoroutine(Explosion());
        else
        {
            Destroy(this.gameObject);
        }
    }

   
}
