using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation()
	{
		PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetInt("PLAYERSTAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt("PLAYERAGILITY", GameInformation.Agility);
		PlayerPrefs.SetInt("PLAYERINTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt("PLAYERSTRENGTH", GameInformation.Strength);

		if (GameInformation.EquipmentOne != null) {
			PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
		}

		Debug.Log ("SAVED ALL INFORMATION");
	}
}
