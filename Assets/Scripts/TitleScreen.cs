using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	Button[] buttons;

	void Start () {
		buttons = this.GetComponentsInChildren<Button> ();
		for (int i = 0; i < buttons.Length; i++) {

			if (buttons [i].name == "StartGameButton") {
				buttons [i].onClick.AddListener (StartGame);
			} 
			else if (buttons [i].name == "LoadGameButton") {
				buttons [i].onClick.AddListener (LoadGame);
			} 
			else if (buttons [i].name == "OptionsButton") {
				buttons [i].onClick.AddListener (Options);
			} 
			else if (buttons [i].name == "ExitGameButton") {
				buttons [i].onClick.AddListener (ExitGame);
			}
		}
	}
		

	void StartGame()
	{
		
		SceneManager.LoadScene ("New Scene");
	}

	void LoadGame()
	{
		SceneManager.LoadScene ("LoadGame");
	}

	void Options()
	{
		SceneManager.LoadScene ("Options");
	}

	void ExitGame()
	{
		Application.Quit ();
		Debug.Log ("Game is exiting");
	}
}
