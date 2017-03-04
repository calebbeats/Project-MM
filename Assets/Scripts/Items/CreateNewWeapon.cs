using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	// Use this for initialization
	void Start () {
		CreateWeapon ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.SpellEffectID.ToString());
		Debug.Log (newWeapon.WeaponType.ToString());

	}

	// Update is called once per frame
	void Update () {

	}

	public void CreateWeapon(){
		
		newWeapon = new BaseWeapon();
		//assign name
		newWeapon.ItemName = "W" + Random.Range(1,101);
		//create weapon description
		newWeapon.ItemDescription = "This is a new weapon";
		//weapon id
		newWeapon.ItemID = Random.Range(1,101);
		//stats
		newWeapon.Agility = Random.Range(1,31);
		newWeapon.Stamina = Random.Range (1, 31);
		newWeapon.Strength = Random.Range (1, 31);
		newWeapon.Intellect = Random.Range (1, 31);
		//choose weapon type
		ChooseWeaponType();
		//spell effect id
		newWeapon.SpellEffectID = Random.Range(1,101);
	}



	private void ChooseWeaponType(){
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
	}
}
