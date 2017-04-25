using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelScript : MonoBehaviour {

    private Vector3 screenPoint;
    bool remove = false;
    GameObject plantToRemove;

    public void OnMouseDown()
    {
            Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

    }

    private void OnMouseDrag()
    {
     
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            this.transform.position = curPosition;
        
    }

    private void OnMouseUp()
    {
        if (remove == true)
        {
            if(plantToRemove.GetComponent<HealthScript>() != null)
            {
                if (plantToRemove.GetComponent<HealthScript>().plant.Equals("Sunflower"))
                {
                    GlobalVariables.Matrix[(int)plantToRemove.transform.position.y][(int)plantToRemove.transform.position.x] = 0;
                    GlobalVariables.score += 50;
                    Destroy(plantToRemove);
                    Destroy(this.gameObject);
                    remove = false;
                }
                if (plantToRemove.GetComponent<HealthScript>().plant.Equals("ShooterFlower"))
                {
                    GlobalVariables.Matrix[(int)plantToRemove.transform.position.y][(int)plantToRemove.transform.position.x] = 0;
                    GlobalVariables.score += 100;
                    Destroy(plantToRemove);
                    Destroy(this.gameObject);
                    remove = false;
                }
                if (plantToRemove.GetComponent<HealthScript>().plant.Equals("ExplodeFlower"))
                {
                    GlobalVariables.Matrix[(int)plantToRemove.transform.position.y][(int)plantToRemove.transform.position.x] = 0;
                    GlobalVariables.score += 100;
                    Destroy(plantToRemove);
                    Destroy(this.gameObject);
                    remove = false;
                }
                if (plantToRemove.GetComponent<HealthScript>().plant.Equals("FreezeFlower"))
                {
                    GlobalVariables.Matrix[(int)plantToRemove.transform.position.y][(int)plantToRemove.transform.position.x] = 0;
                    GlobalVariables.score += 100;
                    Destroy(plantToRemove);
                    Destroy(this.gameObject);
                    remove = false;
                }
                if (plantToRemove.GetComponent<HealthScript>().plant.Equals("MineFlower"))
                {
                    GlobalVariables.Matrix[(int)plantToRemove.transform.position.y][(int)plantToRemove.transform.position.x] = 0;
                    GlobalVariables.score += 100;
                    Destroy(plantToRemove);
                    Destroy(this.gameObject);
                    remove = false;
                }
                if (plantToRemove.GetComponent<HealthScript>().plant.Equals("WallnutFlower"))
                {
                    GlobalVariables.Matrix[(int)plantToRemove.transform.position.y][(int)plantToRemove.transform.position.x] = 0;
                    GlobalVariables.score += 100;
                    Destroy(plantToRemove);
                    Destroy(this.gameObject);
                    remove = false;
                }
            }
        }
        else
        {
            Destroy(this.gameObject);
            remove = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        remove = true;
        plantToRemove = collision.gameObject;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        remove = false;
    }
}
