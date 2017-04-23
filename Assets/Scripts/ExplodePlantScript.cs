using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodePlantScript : MonoBehaviour {

    public GameObject pref1;
    public GameObject pref2;
    float i;
    // Use this for initialization

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<HealthScript>().isEnemy == true)
        {
            Shot();
            collision.collider.GetComponent<HealthScript>().DoDamage(5);
        }
    }

    void Start () {
        i = this.transform.position.x;
        i += 1;

        
    }
	
	public void Shot()
    {
        Instantiate(pref1, new Vector3(i, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            StartCoroutine(Spawn());
       

    }

    IEnumerator Spawn()
    {
        i++;
        yield return new WaitForSeconds(0.05f);
        
        if (i < 12)
        {
            Instantiate(pref2, new Vector3(i, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            StartCoroutine(Spawn());
        }
           

        else if (i < 32)
            StartCoroutine(Spawn());

        else
            Destroy(this.gameObject);
    }
}
