using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass(){
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A melee, heavy armor wearing hero!";
		Stamina = 20;
		Agility = 10;
		Strength = 20;
		Intellect = 5;
	}
}
