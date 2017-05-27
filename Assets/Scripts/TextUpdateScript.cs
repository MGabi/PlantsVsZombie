using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdateScript : MonoBehaviour
{

    public Text text;
    public bool isCountDown;

    // Update is called once per frame
    void Update()
    {
        text = GetComponent<Text>();
        if (isCountDown == false)
            text.text = "SUNS : " + GlobalVariables.score.ToString();
        else
        {
            if (GlobalVariables.Countdown != 0)
                text.text = GlobalVariables.Countdown.ToString() + " secs till zombies spawn";

            else
            {
                text.text = "Zombies have been spawned";
                StartCoroutine(DestroyThis());
            }    
        }

    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}
