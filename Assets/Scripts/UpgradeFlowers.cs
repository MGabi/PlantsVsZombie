using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeFlowers : MonoBehaviour {

	private static string T_SUN = "SUN";
	private static string T_SHOOTER = "SHOOTER";
	private static string T_BOMB = "BOMB";
	private static string T_WALL = "WALL";
	private static string T_FREEZE = "FREEZE";
	private static string T_EXPLODE = "EXPLODE";

	private static string blackOverlayColor = "#969696FF";

	private static string PREF_LVL = "ID_LVL_";
	private static Text balance;
	void Awake()
	{
		balance = GameObject.Find("BalVal").GetComponent<Text>();
		balance.text = PlayerPrefs.GetString(HelperClass.PREF_BALANCE);

		foreach(Text text in GameObject.Find("Content").GetComponentsInChildren<Text>())
		{
			updateText(text);
		}

		foreach(Button button in GameObject.Find("Content").GetComponentsInChildren<Button>()){
			if (!System.Convert.ToBoolean(PlayerPrefs.GetString("ID_F_" + getType(button.name)))){
				Debug.Log("Not unlocked: " + getType(button.name));
				button.image.color = toColor(blackOverlayColor);
				button.interactable = false;
			}
			else
			{
				button.onClick.AddListener(delegate { onClickUpBtn(button); });
			}
		}
	}

	private void onClickUpBtn(Button button)
	{
		string type = getType(button.name);
		int level = System.Convert.ToInt32(PlayerPrefs.GetString(PREF_LVL + type));
		if (level >= 5)
		{
			Debug.Log("Maxed out");
			return;
		}

		Debug.Log("UP_" + (level + 1).ToString() + "_" + type);
		//int cost = (int)(typeof(PlantAttrs).GetField("UP_" + (level + 1).ToString() + "_" + type).GetValue(null));
		int cost = getValueFromInt("UP_" + (level + 1).ToString() + "_" + type);
		Debug.Log(cost.ToString());

		if (System.Convert.ToInt32(balance.text) - cost >= 0)
		{
			level++;
			PlayerPrefs.SetString(PREF_LVL + type, level.ToString());
			PlayerPrefs.SetString(HelperClass.PREF_BALANCE, (System.Convert.ToInt32(balance.text) - cost).ToString());
			PlayerPrefs.Save();
			Debug.Log("Bought");

			if (type.Equals(T_SUN))
				upgradeSunTo(level);

			else if (type.Equals(T_SHOOTER))
				upgradeShooterTo(level);

			else if (type.Equals(T_BOMB))
				upgradeBombTo(level);

			else if (type.Equals(T_WALL))
				upgradeWallTo(level);

			else if (type.Equals(T_FREEZE))
				upgradeFreezeTo(level);

			else if (type.Equals(T_EXPLODE))
				upgradeExplodeTo(level);
		}
		else
		{
			Debug.Log("Not enough money");
		}

		updateText(GameObject.Find("lvl" + type).GetComponent<Text>());
	}

	private void upgradeSunTo(int level)
	{
		string sunH = getValueFrom("SUN_" + level + "_HEALTH").ToString();
		string sunC = getValueFrom("SUN_" + level + "_COOLDOWN").ToString();
		PlayerPrefs.SetString(HelperClass.PREF_HEALTH_SUN, sunH);
		PlayerPrefs.SetString(HelperClass.PREF_SUN_COOLDOWN, sunC);
		PlayerPrefs.Save();
	}

	private void upgradeShooterTo(int level)
	{
		string shootH = getValueFrom("SHOOTER_" + level + "_HEALTH").ToString();
		string shootD = getValueFrom("SHOOTER_" + level + "_DMG").ToString();
		string shootS = getValueFrom("SHOOTER_" + level + "_SPEED").ToString();
		PlayerPrefs.SetString(HelperClass.PREF_HEALTH_SHOOTER, shootH);
		PlayerPrefs.SetString(HelperClass.PREF_DMG_SHOOTER, shootD);
		PlayerPrefs.SetString(HelperClass.PREF_SPEED_SHOOTER, shootS);
		PlayerPrefs.Save();
	}

	private void upgradeBombTo(int level)
	{
		string bombD = getValueFrom("BOMB_" + level + "_DMG").ToString();
		PlayerPrefs.SetString(HelperClass.PREF_DMG_BOMB, bombD);
		PlayerPrefs.Save();
	}

	private void upgradeWallTo(int level)
	{
		string wallH = getValueFrom("WALL_" + level + "_HEALTH").ToString();
		PlayerPrefs.SetString(HelperClass.PREF_HEALTH_WALL, wallH);
		PlayerPrefs.Save();
	}

	private void upgradeFreezeTo(int level)
	{
		string freezeH = getValueFrom("FREEZE_" + level + "_HEALTH").ToString();
		string freezeD = getValueFrom("FREEZE_" + level + "_DMG").ToString();
		string freezeS = getValueFrom("FREEZE_" + level + "_SPEED").ToString();
		string freezeSL = getValueFrom("FREEZE_" + level + "_SLOWMO").ToString();
		PlayerPrefs.SetString(HelperClass.PREF_HEALTH_FREEZE, freezeH);
		PlayerPrefs.SetString(HelperClass.PREF_DMG_FREEZE, freezeD);
		PlayerPrefs.SetString(HelperClass.PREF_SPEED_FREEZE, freezeS);
		PlayerPrefs.SetString(HelperClass.PREF_FREEZE_SLOWMO, freezeSL);
		PlayerPrefs.Save();
	}

	private void upgradeExplodeTo(int level)
	{
		string type = getValueFrom("EXPLODE_" + level + "_TYPE").ToString();
		string radius = getValueFrom("EXPLODE_" + level + "_RADIUS").ToString();
		PlayerPrefs.SetString(HelperClass.PREF_EXPLODE_TYPE, type);
		PlayerPrefs.SetString(HelperClass.PREF_EXPLODE_RADIUS, radius);
		PlayerPrefs.Save();
	}

	private string getValueFrom(string res)
	{
		return (typeof(PlantAttrs).GetField(res).GetValue(null)).ToString();
	}

	private int getValueFromInt(string res)
	{
		return (int)(typeof(PlantAttrs).GetField(res).GetValue(null));
	}

	private void updateText(Text text)
	{
		text.text = "lvl " + PlayerPrefs.GetString(PREF_LVL + getType(text.name));
		balance.text = PlayerPrefs.GetString(HelperClass.PREF_BALANCE);
	}

	private string getType(string tag)
	{
		return tag.Substring(3);
	}

	public Color toColor(string hex)
	{
		hex = hex.Replace("#", "");
		byte a = 255;
		byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

		if (hex.Length == 8)
		{
			a = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
		}
		return new Color32(r, g, b, a);
	}
}
