using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour {

	public Button[] buttons;

	// Use this for initialization
	void Start () {
		buttons = this.GetComponentsInChildren<Button> ();
		for (int i = 0; i < buttons.Length; i++) {

			if (buttons [i].name == "BackButton") {
				buttons [i].onClick.AddListener (BackToTitle);
			} 
		}
	}
	
	// Update is called once per frame
	void BackToTitle()
	{	
		SceneManager.LoadScene ("TitleScreen");
	}
}
