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
	public static bool FLOWER_BOMB = true;
	public static bool FLOWER_WALL = false;
	public static bool FLOWER_FREEZE = false;
	public static bool FLOWER_EXPLODE = true;

	// Plants properties

	public static string PREF_NAME = "ID_NAME";
	public static string PREF_FINALSCORE = "ID_FINALSCORE";
	public static string PREF_BALANCE = "ID_BALANCE";
	public static string PREF_F_SUN = "ID_F_SUN";
	public static string PREF_F_SHOOTER = "ID_F_SHOOTER";
	public static string PREF_F_BOMB = "ID_F_BOMB";
	public static string PREF_F_WALL = "ID_F_WALL";
	public static string PREF_F_FREEZE = "ID_F_FREEZE";
	public static string PREF_F_EXPLODE = "ID_F_EXPLODE";

	public static string PREF_LVL_SUN = "ID_LVL_SUN";
	public static string PREF_LVL_SHOOTER = "ID_LVL_SHOOTER";
	public static string PREF_LVL_BOMB = "ID_LVL_BOMB";
	public static string PREF_LVL_WALL = "ID_LVL_WALL";
	public static string PREF_LVL_FREEZE = "ID_LVL_FREEZE";
	public static string PREF_LVL_EXPLODE = "ID_LVL_FREEZE";

	public static string PREF_HEALTH_SUN = "ID_HEALTH_SUN";
	public static string PREF_HEALTH_SHOOTER = "ID_HEALTH_SUN";
	public static string PREF_HEALTH_WALL = "ID_HEALTH_WALL";
	public static string PREF_HEALTH_FREEZE = "ID_HEALTH_FREEZE";

	public static string PREF_DMG_SHOOTER = "ID_DMG_SHOOTER";
	public static string PREF_DMG_BOMB = "ID_DMG_BOMB";
	public static string PREF_DMG_FREEZE = "ID_DMG_FREEZE";
	public static string PREF_DMG_EXPLODE = "ID_DMG_EXPLODE";

	public static string PREF_SPEED_SHOOTER = "ID_SPEED_SHOOTER";
	public static string PREF_SPEED_FREEZE = "ID_SPEED_FREEZE";

	public static string PREF_SUN_COOLDOWN = "ID_SUN_COOLDOWN";
	public static string PREF_FREEZE_SLOWMO = "ID_SUN_SLOWMO";



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
		//PlayerPrefs.DeleteKey(PREF_BALANCE);
		if (!PlayerPrefs.HasKey(PREF_NAME))
			PlayerPrefs.SetString(PREF_NAME, "Name");

		if (!PlayerPrefs.HasKey(PREF_FINALSCORE))
			PlayerPrefs.SetString(PREF_FINALSCORE, "0");

		if (!PlayerPrefs.HasKey(PREF_BALANCE))
			PlayerPrefs.SetString(PREF_BALANCE, "50000");

		//Available plants
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

		//Level
		if (!PlayerPrefs.HasKey(PREF_LVL_SUN))
			PlayerPrefs.SetString(PREF_LVL_SUN, "1");

		if (!PlayerPrefs.HasKey(PREF_LVL_SHOOTER))
			PlayerPrefs.SetString(PREF_LVL_SHOOTER, "1");

		if (!PlayerPrefs.HasKey(PREF_LVL_BOMB))
			PlayerPrefs.SetString(PREF_LVL_BOMB, "1");

		if (!PlayerPrefs.HasKey(PREF_LVL_WALL))
			PlayerPrefs.SetString(PREF_LVL_WALL, "1");

		if (!PlayerPrefs.HasKey(PREF_LVL_FREEZE))
			PlayerPrefs.SetString(PREF_LVL_FREEZE, "1");

		if (!PlayerPrefs.HasKey(PREF_LVL_EXPLODE))
			PlayerPrefs.SetString(PREF_LVL_EXPLODE, "1");

		//Health
		if (!PlayerPrefs.HasKey(PREF_HEALTH_SUN))
			PlayerPrefs.SetString(PREF_HEALTH_SUN, PlantAttrs.SUN_1_HEALTH);

		if (!PlayerPrefs.HasKey(PREF_HEALTH_SHOOTER))
			PlayerPrefs.SetString(PREF_HEALTH_SHOOTER, PlantAttrs.SHOOTER_1_HEALTH);

		if (!PlayerPrefs.HasKey(PREF_HEALTH_WALL))
			PlayerPrefs.SetString(PREF_HEALTH_WALL, PlantAttrs.WALLNUT_1_HEALTH);

		if (!PlayerPrefs.HasKey(PREF_HEALTH_FREEZE))
			PlayerPrefs.SetString(PREF_HEALTH_FREEZE, PlantAttrs.FREEZE_1_HEALTH);

		//Damage
		if (!PlayerPrefs.HasKey(PREF_DMG_SHOOTER))
			PlayerPrefs.SetString(PREF_DMG_SHOOTER, PlantAttrs.SHOOTER_1_DMG);

		if (!PlayerPrefs.HasKey(PREF_DMG_BOMB))
			PlayerPrefs.SetString(PREF_DMG_BOMB, PlantAttrs.BOMB_1_DMG);

		if (!PlayerPrefs.HasKey(PREF_DMG_FREEZE))
			PlayerPrefs.SetString(PREF_DMG_FREEZE, PlantAttrs.FREEZE_1_DMG);

		//Speed
		if (!PlayerPrefs.HasKey(PREF_SPEED_SHOOTER))
			PlayerPrefs.SetString(PREF_SPEED_SHOOTER, PlantAttrs.SHOOTER_1_SPEED);

		if (!PlayerPrefs.HasKey(PREF_SPEED_FREEZE))
			PlayerPrefs.SetString(PREF_SPEED_FREEZE, PlantAttrs.FREEZE_1_SPEED);

		//Others
		if (!PlayerPrefs.HasKey(PREF_SUN_COOLDOWN))
			PlayerPrefs.SetString(PREF_SUN_COOLDOWN, PlantAttrs.SUN_1_COOLDOWN);

		if (!PlayerPrefs.HasKey(PREF_FREEZE_SLOWMO))
			PlayerPrefs.SetString(PREF_FREEZE_SLOWMO, PlantAttrs.FREEZE_1_SLOWMO);

		PlayerPrefs.Save();
	}

	public void saveData()
	{
		PlayerPrefs.Save();
	}
}

