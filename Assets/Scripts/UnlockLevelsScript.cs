using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevelsScript : MonoBehaviour {

	private Button btn1;
	private Button btn2;
	private Button btn3;
	private Button btn4;
	private Button btn5;

	void Start () {
		btn1 = GameObject.Find("levelOneBtn").GetComponent<Button>();
		btn2 = GameObject.Find("levelTwoBtn").GetComponent<Button>();
		btn3 = GameObject.Find("levelThreeBtn").GetComponent<Button>();
		btn4 = GameObject.Find("levelForBtn").GetComponent<Button>();
		btn5 = GameObject.Find("levelFiveBtn").GetComponent<Button>();

		GlobalVariables.score = 50;
        GlobalVariables.Countdown = 10;


        if (PlayerPrefs.GetInt(HelperClass.LEVEL_CURRENT) == 1)
		{
			btn2.interactable = false;
			btn3.interactable = false;
			btn4.interactable = false;
			btn5.interactable = false;
		}

		if (PlayerPrefs.GetInt(HelperClass.LEVEL_CURRENT) == 2)
		{
			btn3.interactable = false;
			btn4.interactable = false;
			btn5.interactable = false;
		}

		if (PlayerPrefs.GetInt(HelperClass.LEVEL_CURRENT) == 3)
		{
			btn4.interactable = false;
			btn5.interactable = false;
		}

		if (PlayerPrefs.GetInt(HelperClass.LEVEL_CURRENT) == 4)
		{
			btn5.interactable = false;
		}
	}
}
