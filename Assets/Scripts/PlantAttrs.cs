﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAttrs : MonoBehaviour
{
	public static int UP_2_SUN = 1000;
	public static int UP_3_SUN = 2000;
	public static int UP_4_SUN = 3000;
	public static int UP_5_SUN = 4000;

	public static int UP_2_SHOOTER = 1000;
	public static int UP_3_SHOOTER = 1000;
	public static int UP_4_SHOOTER = 1000;
	public static int UP_5_SHOOTER = 1000;

	public static int UP_2_BOMB = 1000;
	public static int UP_3_BOMB = 1000;
	public static int UP_4_BOMB = 1000;
	public static int UP_5_BOMB = 1000;

	public static int UP_2_WALL = 1000;
	public static int UP_3_WALL = 1000;
	public static int UP_4_WALL = 1000;
	public static int UP_5_WALL = 1000;

	public static int UP_2_FREEZE = 1000;
	public static int UP_3_FREEZE = 1000;
	public static int UP_4_FREEZE = 1000;
	public static int UP_5_FREEZE = 1000;

	public static int UP_2_EXPLODE = 1000;
	public static int UP_3_EXPLODE = 1000;
	public static int UP_4_EXPLODE = 1000;
	public static int UP_5_EXPLODE = 1000;

	//Level 1
	public static string SUN_1_HEALTH = "200";
	public static string SUN_1_COOLDOWN = "15";

	public static string SHOOTER_1_HEALTH = "3";
	public static string SHOOTER_1_DMG = "1";
	public static string SHOOTER_1_SPEED = "4";

	public static string BOMB_1_DMG = "4";

	public static string WALL_1_HEALTH = "5";

	public static string FREEZE_1_HEALTH = "3";
	public static string FREEZE_1_DMG = "1";
	public static string FREEZE_1_SPEED = "4";
	public static string FREEZE_1_SLOWMO = "0.00005";

	//Level 2
	public static string SUN_2_HEALTH = "4";
	public static string SUN_2_COOLDOWN = "4";

	public static string SHOOTER_2_HEALTH = "4";
	public static string SHOOTER_2_DMG = "2";
	public static string SHOOTER_2_SPEED = "3.4";

	public static string BOMB_2_DMG = "5";

	public static string WALL_2_HEALTH = "7";

	public static string FREEZE_2_HEALTH = "4";
	public static string FREEZE_2_DMG = "2.5";
	public static string FREEZE_2_SPEED = "3.6";
	public static string FREEZE_2_SLOWMO = "0.000055";

	//Level 3
	public static string SUN_3_HEALTH = "5";
	public static string SUN_3_COOLDOWN = "3";

	public static string SHOOTER_3_HEALTH = "5";
	public static string SHOOTER_3_DMG = "3";
	public static string SHOOTER_3_SPEED = "3";

	public static string BOMB_3_DMG = "6";

	public static string WALL_3_HEALTH = "9";

	public static string FREEZE_3_HEALTH = "5";
	public static string FREEZE_3_DMG = "3.6";
	public static string FREEZE_3_SPEED = "3";
	public static string FREEZE_3_SLOWMO = "0.00006";

	//Level 4
	public static string SUN_4_HEALTH = "6";
	public static string SUN_4_COOLDOWN = "2.5";

	public static string SHOOTER_4_HEALTH = "6";
	public static string SHOOTER_4_DMG = "3.6";
	public static string SHOOTER_4_SPEED = "2.5";

	public static string BOMB_4_DMG = "7";

	public static string WALL_4_HEALTH = "11";

	public static string FREEZE_4_HEALTH = "6";
	public static string FREEZE_4_DMG = "4";
	public static string FREEZE_4_SPEED = "2.5";
	public static string FREEZE_4_SLOWMO = "0.000065";

	//Level 5
	public static string SUN_5_HEALTH = "7";
	public static string SUN_5_COOLDOWN = "2";

	public static string SHOOTER_5_HEALTH = "7";
	public static string SHOOTER_5_DMG = "4";
	public static string SHOOTER_5_SPEED = "2";

	public static string BOMB_5_DMG = "8";

	public static string WALL_5_HEALTH = "13";

	public static string FREEZE_5_HEALTH = "7";
	public static string FREEZE_5_DMG = "4";
	public static string FREEZE_5_SPEED = "2";
	public static string FREEZE_5_SLOWMO = "0.00007";


	/**
	 * TYPE = 1 -> pe coloana
	 * TYPE = 2 -> pe linie
	 * TYPE = 3 -> pe linie si coloana
	 * TYPE = 4 -> pe o anumita raza
	 */
	public static string EXPLODE_1_TYPE = "1";
	public static string EXPLODE_1_RADIUS = "0";

	public static string EXPLODE_2_TYPE = "2";
	public static string EXPLODE_2_RADIUS = "0";

	public static string EXPLODE_3_TYPE = "3";
	public static string EXPLODE_3_RADIUS = "0";

	public static string EXPLODE_4_TYPE = "4";
	public static string EXPLODE_4_RADIUS = "2";

	public static string EXPLODE_5_TYPE = "4";
	public static string EXPLODE_5_RADIUS = "5";
}
