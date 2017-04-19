using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveScript : MonoBehaviour {

    public int direction;
    public float speed;

	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x + direction * speed, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.x >= 20)
            Destroy(this.gameObject);
	}
}
