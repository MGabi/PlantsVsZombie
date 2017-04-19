using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCollectScript : MonoBehaviour
{

    public void OnMouseDown()
    {
        GlobalVariables.score += 20;
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > 5)
            Destroy(this.gameObject);
    }
}