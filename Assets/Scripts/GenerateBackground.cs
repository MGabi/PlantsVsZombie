using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour {

    public GameObject grass1;
    public GameObject grass2;
  

	// Use this for initialization
	void Start () {
		for(int i=0;i<5;i++)
        {
            for(int j=0;j<10;j++)
            {
                if((i+j)%2==0)
                {
                    Instantiate(grass1, new Vector3(j, i, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(grass2, new Vector3(j, i, 0), Quaternion.identity);
                }
            }
        }
    
	}
	
	
}
