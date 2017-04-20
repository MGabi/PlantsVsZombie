using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class HelperClass : MonoBehaviour
{
	public static HelperClass instance = null;

	public static bool FLOWER_SUN = true;
	public static bool FLOWER_SHOOTER = true;
	public static bool FLOWER_BOMB = false;
	public static bool FLOWER_WALL = false;
	public static bool FLOWER_FREEZE = false;
	public static bool FLOWER_EXPLODE = false;

	private static int ROWS_IN_TXT_FILE = 9;

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
		fileContent = new string[9];
		//filePath = "E://OtherProjects//PlantsVsZombie//Assets//UserData//userDetails.txt";
		filePath = Directory.GetCurrentDirectory() + "//Assets//UserData//userDetails.txt";
		try
		{
			using (StreamReader sr = File.OpenText(filePath))
			{
				string s = string.Empty;
				for (int i = 0; i < ROWS_IN_TXT_FILE; i++)
				{
					s = sr.ReadLine();
					fileContent[i] = s;
					if (i == 0)
						setPlayerName(s);
					else if (i == 1)
						setPlayerFinalScore(System.Int32.Parse(s));
					else if (i == 2)
						setPlayerBalance(System.Int32.Parse(s));
					else if (i == 3)
						FLOWER_SUN = System.Boolean.Parse(s);
					else if (i == 4)
						FLOWER_SHOOTER = System.Boolean.Parse(s);
					else if (i == 5)
						FLOWER_BOMB = System.Boolean.Parse(s);
					else if (i == 6)
						FLOWER_WALL = System.Boolean.Parse(s);
					else if (i == 7)
						FLOWER_FREEZE = System.Boolean.Parse(s);
					else if (i == 8)
						FLOWER_EXPLODE = System.Boolean.Parse(s);
				}
			}
		}catch(System.Exception e)
		{
			
		}
	}

	public void setNameInTextBox(string s)
	{
		Text textName = GameObject.Find("Canvas/nameText").GetComponent<Text>();
		textName.text = s;
	}

	public void saveData()
	{
		System.IO.File.WriteAllText(filePath, string.Empty);
		using (StreamWriter sw = File.AppendText(filePath))
		{
			for(int i=0; i<ROWS_IN_TXT_FILE; i++)
			{
				sw.WriteLine(fileContent[i]);
			}
		}
	}

	public void setBOMB(bool value)
	{
		FLOWER_BOMB = value;
		fileContent[5] = value.ToString().ToLower();
		saveData();
	}

	public void setWALL(bool value)
	{
		FLOWER_WALL = value;
		fileContent[6] = value.ToString().ToLower();
		saveData();
	}

	public void setFREEZE(bool value)
	{
		FLOWER_FREEZE = value;
		fileContent[7] = value.ToString().ToLower();
		saveData();
	}

	public void setEXPLODE(bool value)
	{
		FLOWER_EXPLODE = value;
		fileContent[8] = value.ToString().ToLower();
		saveData();
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

