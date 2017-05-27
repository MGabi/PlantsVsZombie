using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBulletDestroy : MonoBehaviour {

    float i;
	void Start () {
        i = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x - i >= 3)
            Destroy(this.gameObject);
	}
}
