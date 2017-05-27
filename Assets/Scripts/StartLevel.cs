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

	public GameObject corpo;
    public GameObject troglo;
    public GameObject scufu;
    public GameObject manager;
    public GameObject specialist;
    public GameObject profesoara;
    public GameObject directoare;

    public int[][] levelMatrix;
    int i = 15;
    int wave = 0;
    float time;

    private void Start()
    {
        time = GlobalVariables.Countdown;
		string levelID = PlayerPrefs.GetString(LEVEL_TAG);
		//levelMatrix = LevelsMatrix.levelOne;
		if (levelID.Equals(LEVEL_1))
			levelMatrix = LevelsMatrix.levelOne;
		if (levelID.Equals(LEVEL_2))
			levelMatrix = LevelsMatrix.levelTwo;
		if (levelID.Equals(LEVEL_3))
			levelMatrix = LevelsMatrix.levelThree;
		if (levelID.Equals(LEVEL_4))
			levelMatrix = LevelsMatrix.levelFour;
		if (levelID.Equals(LEVEL_5))
			levelMatrix = LevelsMatrix.levelFive;
		StartCoroutine(CountDown());
     
	}

    IEnumerator CountDown()
    {
        time--;
        GlobalVariables.Countdown = time;
        yield return new WaitForSeconds(1);
        if (time > 0)
            StartCoroutine(CountDown());
        if (time == 0)
            Spawn();
    }


	void Spawn()
    {
        if(wave == 0)
            StartCoroutine(SpawnZomb(3.5f,  corpo, 15));
      
    
        


    }

    IEnumerator SpawnZomb(float waitTime,GameObject obj,int nr)
    {
        yield return new WaitForSeconds(waitTime);
        int row = Random.Range(0, 5);
        Instantiate(obj, new Vector3(17, row, 0), Quaternion.identity);
        GlobalVariables.ZombieOnLane[row]++;
        nr--;
        if (nr > 0)
            StartCoroutine(SpawnZomb(waitTime, obj, nr));
        else
        {
            wave++;
            if(wave==1)
                StartCoroutine(SpawnZomb(3.5f, troglo, 10));
            if(wave==2)
                StartCoroutine(SpawnZomb(3.5f, scufu,7));
            if (wave == 3)
                StartCoroutine(SpawnZomb(15f, scufu, 0));
            if (wave == 4)
                StartCoroutine(SpawnZomb(4f, corpo, 10));
            if (wave == 5)
                StartCoroutine(SpawnZomb(4f, troglo, 7));
            if (wave == 6)
                StartCoroutine(SpawnZomb(4f, scufu, 10));
            if (wave == 7)
                StartCoroutine(SpawnZomb(4f, manager, 10));
            if (wave == 8)
                StartCoroutine(SpawnZomb(4f, specialist, 3));
            if (wave == 9)
                StartCoroutine(SpawnZomb(4f, profesoara, 1));
            if (wave == 10)
                StartCoroutine(SpawnZomb(10f, corpo, 0));
            if (wave == 11)
                StartCoroutine(SpawnZomb(2.15f, corpo, 5));
            if (wave == 12)
                StartCoroutine(SpawnZomb(2.15f, troglo, 5));
            if (wave == 13)
                StartCoroutine(SpawnZomb(2.15f, scufu, 7));
            if (wave == 14)
                StartCoroutine(SpawnZomb(2.15f, manager, 6));
            if (wave == 15)
                StartCoroutine(SpawnZomb(2.15f, specialist, 9));
            if (wave == 16)
                StartCoroutine(SpawnZomb(2.15f, profesoara, 8));
            if (wave == 17)
                StartCoroutine(SpawnZomb(2.15f, directoare, 1));
        }
    }

   

    
   


}
