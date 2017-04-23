using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveScript : MonoBehaviour {

    public int direction;
    public float speed;
    public float speed2;
    public bool isSlowed = false;
    public GameObject snow;
    float slow;

    private void Start()
    {
        speed2 = speed;
    }

    // Update is called once per frame
    public void Update () {

        this.transform.position = new Vector3(this.transform.position.x + direction * speed, this.transform.position.y, this.transform.position.z);
        if(isSlowed == true)
        {
            slow = (float)System.Double.Parse(PlayerPrefs.GetString(HelperClass.PREF_FREEZE_SLOWMO));
            float x = UnityEngine.Random.Range(-0.5f, 0.5f);
            Instantiate(snow, new Vector3(this.transform.position.x,(int)this.transform.position.y + x,this.transform.position.z), Quaternion.identity);
            if(speed >= 0.002f)
            {
                speed -= slow;
            }
        }

        if (this.transform.position.x >= 20 || this.transform.position.x <= -10)
            Destroy(this.gameObject);
	}

 

   


}
