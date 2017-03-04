using UnityEngine;
using System.Collections;

public class BasePlayer  {

	private string playerName;
	private int playerLevel;
	private int playerEXP;
	private BaseCharacterClass playerClass;

	private int stamina;
	private int agility;
	private int intellect;
	private int strength; 

	public string PlayerName {
		get{ return playerName; }
		set{ playerName = value; }
	}

	public int PlayerLevel {
		get{ return playerLevel; }
		set{ playerLevel = value; }
	}

	public int PlayerEXP {
		get{ return playerEXP; }
		set{ playerEXP = value; }
	}

	public BaseCharacterClass PlayerClass {
		get{ return playerClass; }
		set{ playerClass = value; }
	}

	public int Stamina {
		get{ return stamina; }
		set{ stamina = value; }
	}

	public int Agility {
		get{ return agility; }
		set{ agility = value; }
	}

	public int Intellect {
		get{ return intellect; }
		set{ intellect = value; }
	}

	public int Strength {
		get{ return strength; }
		set{ strength = value; }
	}
}
