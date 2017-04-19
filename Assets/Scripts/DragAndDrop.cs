using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragAndDrop : MonoBehaviour
{
    public GameObject prefab;
    public int price;
    private Vector3 screenPoint;


    bool bought = true;

    public void OnMouseDown()
    {

        if (GlobalVariables.score >= price)
        {
            bought = true;

            Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
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
            transform.position = curPosition;
        }
    }

    private void OnMouseUp()
    {
        if (bought == true)
        {
            if (this.transform.position.x >= 0 &&
                this.transform.position.x <= 9 &&
                this.transform.position.y >= 0 &&
                this.transform.position.x <= 4 &&
                GlobalVariables.Matrix[(int)transform.position.y][(int)transform.position.x] == 0)
            {

                GlobalVariables.Matrix[(int)transform.position.y][(int)transform.position.x] = 1;
                this.transform.position = new Vector3((int)transform.position.x, (int)transform.position.y, transform.position.z);
                Instantiate(prefab, this.transform.position, Quaternion.identity);
                Destroy(this.gameObject);

            }
            else
            {
                Destroy(this.gameObject);
                GlobalVariables.score += price;
            }
        }
    }



}
