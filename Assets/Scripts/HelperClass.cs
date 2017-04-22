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

	public static string PREF_NAME = "ID_NAME";
	public static string PREF_FINALSCORE = "ID_FINALSCORE";
	public static string PREF_BALANCE = "ID_BALANCE";
	public static string PREF_F_SUN = "ID_F_SUN";
	public static string PREF_F_SHOOTER = "ID_F_SHOOTER";
	public static string PREF_F_BOMB = "ID_F_BOMB";
	public static string PREF_F_WALL = "ID_F_WALL";
	public static string PREF_F_FREEZE = "ID_F_FREEZE";
	public static string PREF_F_EXPLODE = "ID_F_EXPLODE";

	void Awake()
	{
		//setNameInTextBox();
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
		initData();
       // DontDestroyOnLoad(gameObject);
	}

	public void initData()
	{
		//PlayerPrefs.DeleteAll();
		if (!PlayerPrefs.HasKey(PREF_NAME))
			PlayerPrefs.SetString(PREF_NAME, "Name");

		if (!PlayerPrefs.HasKey(PREF_FINALSCORE))
			PlayerPrefs.SetString(PREF_FINALSCORE, "0");

		if (!PlayerPrefs.HasKey(PREF_BALANCE))
			PlayerPrefs.SetString(PREF_BALANCE, "0");

		if (!PlayerPrefs.HasKey(PREF_F_SUN))
			PlayerPrefs.SetString(PREF_F_SUN, "true");

		if (!PlayerPrefs.HasKey(PREF_F_SHOOTER))
			PlayerPrefs.SetString(PREF_F_SHOOTER, "true");

		if (!PlayerPrefs.HasKey(PREF_F_BOMB))
			PlayerPrefs.SetString(PREF_F_BOMB, "false");

		if (!PlayerPrefs.HasKey(PREF_F_WALL))
			PlayerPrefs.SetString(PREF_F_WALL, "false");

		if (!PlayerPrefs.HasKey(PREF_F_FREEZE))
			PlayerPrefs.SetString(PREF_F_FREEZE, "false");

		if (!PlayerPrefs.HasKey(PREF_F_EXPLODE))
			PlayerPrefs.SetString(PREF_F_EXPLODE, "false");

		PlayerPrefs.Save();
	}

	public void saveData()
	{
		PlayerPrefs.Save();
	}
}

