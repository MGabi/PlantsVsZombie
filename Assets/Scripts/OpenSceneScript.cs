using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine {
    public class OpenSceneScript : MonoBehaviour {
        public void openScene(string sceneName) {
            SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}
