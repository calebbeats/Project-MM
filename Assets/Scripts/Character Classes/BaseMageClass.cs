using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass()
	{
		CharacterClassName = "Mage";
		CharacterClassDescription = "Uses magic to defeat enemies";
		Stamina = 10;
		Agility = 15;
		Strength = 10;
		Intellect = 25;
	}
}
