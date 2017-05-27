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
				//UnityEngine.SceneManagement.SceneManager.LoadScene("GameWinScene");
				Debug.Log("GAME WON!!!");
				Debug.Log("GAME WON!!!");
				Debug.Log("GAME WON!!!");
			}
        }
    }
}
