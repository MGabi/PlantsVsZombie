using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x < -2)
        {
			//UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
			Application.LoadLevel("GameOverScene");
		}
	}
}
