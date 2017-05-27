using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour {

    void Update()
    {
        if (GlobalVariables.spawningFinished == true)
        {
            bool k = true;
            for (int i = 0; i < 5; i++)
                if (GlobalVariables.ZombieOnLane[i] > 0)
                    k = false;

            if (k == true)
            {
				
		
				int suns = GlobalVariables.score;
				int bal = System.Int32.Parse(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
				PlayerPrefs.SetString(HelperClass.PREF_BALANCE, (bal + suns*10).ToString());

                StartCoroutine(Win());
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(3);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameWinScene");
    }
}
