using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenSceneScript : MonoBehaviour {
	public void openScene(string sceneName){
		Application.LoadLevel (sceneName);
	}
}
