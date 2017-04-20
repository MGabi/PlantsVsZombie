using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class HelperClass : MonoBehaviour
{
	public static HelperClass instance = null;

	private static int ROWS_IN_TXT_FILE = 3;

	private static string playerName;
	private static int playerBalance;
	private static int playerFinalScore;

	private static string[] fileContent;

	private static string filePath;

    

        void Awake()
	{
		//setNameInTextBox();
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
		DontDestroyOnLoad(gameObject);
		readData();
	}

	public void readData()
	{
		/*
		filePath = Directory.GetCurrentDirectory();
		filePath = Directory.GetDirectoryRoot(filePath);
		filePath = filePath + "//UserData//userdetails.txt";*/
		filePath = "D:\\OtherProjects\\PlantsVsZombie\\Assets\\UserData\\userDetails.txt";
		try
		{
			using (StreamReader sr = File.OpenText(filePath))
			{
				string s = string.Empty;
				for (int i = 0; i < ROWS_IN_TXT_FILE; i++)
				{
					s = sr.ReadLine();
					if (i == 0)
						setPlayerName(s);
					else if (i == 1)
						setPlayerFinalScore(System.Int32.Parse(s));
					else
						setPlayerBalance(System.Int32.Parse(s));
				}
			}
		}catch(System.Exception e)
		{

		}

		setNameInTextBox(getPlayerName());
	}

	public void setNameInTextBox(string s)
	{
        if(GameObject.FindWithTag("nameText").GetComponent<Text>() != null)
        {
            Text textName = GameObject.FindWithTag("nameText").GetComponent<Text>();
            textName.text = getPlayerName();
        }
        
	}

	public void saveData()
	{

	}

	public int getPlayerFinalScore()
	{
		return playerFinalScore;
	}

	public void setPlayerFinalScore(int score)
	{
		playerFinalScore = score;
	}

	public int getPlayerBalance()
	{
		return playerBalance;
	}

	public void setPlayerBalance(int balance)
	{
		playerBalance = balance;
	}

	public string getPlayerName()
	{
		return playerName;
	}

	public void setPlayerName(string name)
	{
		playerName = name;
	}
}

