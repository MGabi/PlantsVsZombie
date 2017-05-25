using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour {

	private static string LEVEL_1 = "levelOne";
	private static string LEVEL_2 = "levelTwo";
	private static string LEVEL_3 = "levelThree";
	private static string LEVEL_4 = "levelFour";
	private static string LEVEL_5 = "levelFive";
	private static string LEVEL_TAG = "LEVEL_ID";

	public GameObject pref1;
    public int[][] levelMatrix;
    int i = 0;
    float time;

    private void Start()
    {
        time = GlobalVariables.Countdown;
		string levelID = PlayerPrefs.GetString(LEVEL_TAG);
		//levelMatrix = LevelsMatrix.levelOne;
		if (levelID.Equals(LEVEL_1))
			levelMatrix = LevelsMatrix.levelOne;
        StartCoroutine(CountDown());
     
	}

    IEnumerator CountDown()
    {
        time--;
        GlobalVariables.Countdown = time;
        yield return new WaitForSeconds(1);
        if (time > 0)
            StartCoroutine(CountDown());
        if(time == 0)
            StartCoroutine(SpawnZombies());
    }

	IEnumerator SpawnZombies()
	{
		yield return new WaitForSeconds(levelMatrix[i][0]);
		Spawn();
	}

	void Spawn()
    {
        Instantiate(pref1, new Vector3(12, levelMatrix[i][1], 0), Quaternion.identity);
        GlobalVariables.ZombieOnLane[levelMatrix[i][1]]++;
        i++;

        if (i < levelMatrix.Length -1)
        {
            StartCoroutine(SpawnZombies());
        }
        else
            GlobalVariables.spawningFinished = true;
    }
	
	
}
