using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdateScript : MonoBehaviour
{

    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "Score : " + GlobalVariables.score.ToString();

    }
}
