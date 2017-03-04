using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	Vector3 PlayerPOS;
	float distance = 1.5f;

	void Start()
	{
		PlayerPOS = GameObject.Find ("Player").transform.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("MainCamera").transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - distance);
	}
}
