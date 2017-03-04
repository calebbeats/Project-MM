using UnityEngine;
using System.Collections;
/*
	This script stores information across scenes. 
*/
public class GameInformation : MonoBehaviour {

	//Awake() is ran before Start().
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}


	public static BaseEquipment EquipmentOne{ get; set; }
	public static string PlayerName{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static BaseCharacterClass PlayerClass{ get; set; }
	public static int Stamina{ get; set; }
	public static int Agility{ get; set; }
	public static int Intellect{ get; set; }
	public static int Strength{ get; set; }

}
