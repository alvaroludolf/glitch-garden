using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevel = 0.0f;

	// Use this for initialization
	void Start () {
        if (autoLoadNextLevel > 0) {
            Invoke("LoadNextLevel", autoLoadNextLevel);
        }
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
