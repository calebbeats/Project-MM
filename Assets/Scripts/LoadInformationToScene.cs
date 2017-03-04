using UnityEngine;
using System.Collections;

public class LoadInformationToScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

		LoadInformation.LoadAllInformation ();

		Debug.Log("Player Name: " + GameInformation.PlayerName) ;
		Debug.Log("Player Level: " + GameInformation.PlayerLevel) ;
		Debug.Log("Player Stamina: " + GameInformation.Stamina) ;
		Debug.Log("Player Agility: " + GameInformation.Agility) ;
		Debug.Log("Player Intellect: " + GameInformation.Intellect) ;
		Debug.Log("Player Strenth: " + GameInformation.Strength);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
