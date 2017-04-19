using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenSceneScript : MonoBehaviour {
	public string sceneName;

	void Start () {
		Application.LoadLevel (sceneName);
	}
}
