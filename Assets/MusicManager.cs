using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusic;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
        audioSource = gameObject.GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnDestroy() {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode) {
        int level = scene.buildIndex;
        if (level < levelMusic.Length) {
            AudioClip clip = levelMusic[level];
            if (clip) {
                audioSource.Stop();
                audioSource.clip = clip;
                audioSource.Play();
            }
        }
    }

}
