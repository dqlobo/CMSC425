using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {
	
	void Update () {
		float tiltMultiplier = 15;
		float tiltHorizontal = -tiltMultiplier * Input.GetAxis ("Horizontal");
		float tiltVertical = tiltMultiplier * Input.GetAxis ("Vertical") ;

		Vector3 tiltAmount = new Vector3 (tiltVertical, 0, tiltHorizontal);
		Quaternion rotation = Quaternion.Euler (tiltAmount);

		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 3.5F);
				
	}
}
