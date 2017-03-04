using UnityEngine;
using System.Collections;

public class LoadInformation  {

	public static void LoadAllInformation()
	{
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.Stamina = PlayerPrefs.GetInt ("PLAYERSTAMINA");
		GameInformation.Agility = PlayerPrefs.GetInt ("PLAYERAGILITY");
		GameInformation.Intellect = PlayerPrefs.GetInt ("PLAYERINTELLECT");
		GameInformation.Strength = PlayerPrefs.GetInt ("PLAYERSTRENGTH");

		if (PlayerPrefs.GetString ("EQUIPMENTITEM1") != null) {
			GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENTITEM1");
		}

		Debug.Log ("LOADED INFORMATION");
	}
}
