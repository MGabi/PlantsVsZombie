using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodePlantScript : MonoBehaviour {

    public float interval;
    float interval2;
    public GameObject launch1;
    public GameObject fireBeam1;
    public GameObject launch2;
    public GameObject launch3;
    public GameObject fireBeam2;
    float i, j1, j2;
    // Use this for initialization



    void Start () {
        i = this.transform.position.x;
        j1 = this.transform.position.y + 1;
        j2 = this.transform.position.y - 1;
        i += 1;
        interval2 = interval;
        
    }

    private void Update()
    {
        if (interval2 <= 0)
        {
            i = this.transform.position.x + 1;
            j1 = this.transform.position.y + 1;
            j2 = this.transform.position.y - 1;
            
            
            ColumnUpShot();
            LineShot();
            ColumnDownShot();
            interval2 = interval;
        }
        else
            interval2 -= Time.deltaTime;
    }

    public void ColumnUpShot()
    {

        Instantiate(launch2, new Vector3(this.transform.position.x, this.transform.position.y+1, this.transform.position.z),Quaternion.identity);
        StartCoroutine(SpawnColumnUp());
        
     

    }

    public void ColumnDownShot()
    {
        Instantiate(launch3, new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z), Quaternion.identity);
        StartCoroutine(SpawnColumnDown());
    }

    public void LineShot()
    {
        Instantiate(launch1, new Vector3(i, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            StartCoroutine(SpawnLine());
       

    }

    IEnumerator SpawnLine()
    {
        i++;
        yield return new WaitForSeconds(0.05f);
        
        if (i < 17)
        {
            Instantiate(fireBeam1, new Vector3(i, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            StartCoroutine(SpawnLine());
        }
    }

    IEnumerator SpawnColumnUp()
    {
        j1++;
       
        yield return new WaitForSeconds(0.05f);

        if(j1 < 5)
        {
            Instantiate(fireBeam2, new Vector3(this.transform.position.x, j1, this.transform.position.z), Quaternion.identity);
            StartCoroutine(SpawnColumnUp());
        }
   
            
    }

    IEnumerator SpawnColumnDown()
    {
        j2--;

        yield return new WaitForSeconds(0.05f);

        if (j2 >= 0)
        {
            Instantiate(fireBeam2, new Vector3(this.transform.position.x, j2, this.transform.position.z), Quaternion.identity);
            StartCoroutine(SpawnColumnDown());
        }


    }
}
