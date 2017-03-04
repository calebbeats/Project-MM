using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Animator anim;
	GameObject playerInventory;

	public float moveSpeed = 2f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		playerInventory = GameObject.Find("PlayerMenu");
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKey ("w")) {
			transform.Translate ((Vector3.up) * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey ("a")) {
			transform.Translate ((Vector3.left) * moveSpeed * Time.deltaTime);
			anim.SetBool ("isMoving", true);
			anim.SetInteger ("State", 4);
		}
		if (Input.GetKey ("s")) {
			transform.Translate ((Vector3.down) * moveSpeed * Time.deltaTime);
			anim.SetBool ("isMoving", true);
			anim.SetInteger ("State", 2);
		}
		if (Input.GetKey ("d")) {
			transform.Translate ((Vector3.right) * moveSpeed * Time.deltaTime);
			anim.SetBool ("isMoving", true);
			anim.SetInteger ("State", 1);
		}

		if (Input.GetKey ("w") && !Input.GetKey ("a") && !Input.GetKey ("d")) {
			anim.SetBool ("isMoving", true);
			anim.SetInteger ("State", 3);
		}


		if (!Input.GetKey ("w") && !Input.GetKey ("a") && !Input.GetKey ("d") && !Input.GetKey ("s")) {
			anim.SetBool ("isMoving", false);
		}
			
		if (Input.GetKeyDown ("i")) {
			Canvas can = playerInventory.GetComponent<Canvas> ();

			if (can.enabled == false) {can.enabled = true;} 
			else {can.enabled = false;}
		}

		if(Input.GetKeyDown("f"))
		{
			
		}
	}		
}


 

