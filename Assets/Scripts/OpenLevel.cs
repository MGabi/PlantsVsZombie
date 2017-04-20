using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine {
	public class OpenLevel : MonoBehaviour{
		public void openLevel(string level){
			PlayerPrefs.SetString("LEVEL_ID", level);
			UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
		}
	}
}
