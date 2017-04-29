using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragAndDrop : MonoBehaviour
{
    public GameObject prefab;
    public GameObject selectionBox;
    public int price;
    private Vector3 screenPoint;
    private GameObject otherGO;

    bool bought = true;

    public void OnMouseDown()
    {

        if (GlobalVariables.score >= price)
        {
            bought = true;
            
            Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
            otherGO = Instantiate(selectionBox, this.transform.position, Quaternion.identity) as GameObject;
            GlobalVariables.score -= price;
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            
        }
        else
        {
            bought = false;
        }

    }

    private void OnMouseDrag()
    {
        if (bought == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            this.transform.position = curPosition;
            otherGO.transform.position = new Vector3((int)Camera.main.ScreenToWorldPoint(Input.mousePosition).x, (int)Camera.main.ScreenToWorldPoint(Input.mousePosition).y, this.transform.position.z);


        }
    }

    private void OnMouseUp()
    {
        if (bought == true)
        {
            if (this.transform.position.x + this.transform.lossyScale.x/2 >= 0 &&
                this.transform.position.x - this.transform.lossyScale.x/2 <= 9 &&
                this.transform.position.y + this.transform.lossyScale.y/2 >= 0 &&
                this.transform.position.y - this.transform.lossyScale.y/2 <= 4 &&
                GlobalVariables.Matrix[(int)Camera.main.ScreenToWorldPoint(Input.mousePosition).y][(int)Camera.main.ScreenToWorldPoint(Input.mousePosition).x] == 0)
            {
                GlobalVariables.Matrix[(int)Camera.main.ScreenToWorldPoint(Input.mousePosition).y][(int)Camera.main.ScreenToWorldPoint(Input.mousePosition).x] = 1;
                //GlobalVariables.Matrix[(int)(transform.position.y + this.transform.lossyScale.y / 2)][(int)(transform.position.x + this.transform.lossyScale.x / 2)] = 1;
                this.transform.position = new Vector3((int)(Camera.main.ScreenToWorldPoint(Input.mousePosition).x),(int)(Camera.main.ScreenToWorldPoint(Input.mousePosition).y), transform.position.z);
                Instantiate(prefab, this.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
                Destroy(otherGO);
            }
            else
            {
                Destroy(this.gameObject);
                Destroy(otherGO);
                GlobalVariables.score += price;
            }
        }
    }



}
