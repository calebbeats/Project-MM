using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	static bool AudioBegin = false;
	static bool SceneChange = false;
	public AudioClip Return;
	public AudioClip Jazz;

	void Awake()
	{
		if (!AudioBegin) {
			this.GetComponent<AudioSource>().Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		}
	}
	void Update() {
		if (SceneManager.GetActiveScene().name == "New Scene"  && !SceneChange) {
			GetComponent<AudioSource>().Stop ();
			AudioBegin = false;
			GetComponent<AudioSource>().clip = Jazz;
			GetComponent<AudioSource> ().Play ();
			SceneChange = true;
		}
	}
	
}
