using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {
	
	void Update () 
	{		
		RegisterControls ();
	}

	void RegisterControls () 
	{
		SetTiltControlWithMultiplier (30);		
	}

	void SetTiltControlWithMultiplier(float multiplier)
	{
		float tiltHorizontal = -multiplier * Input.GetAxis ("Horizontal");
		float tiltVertical = multiplier * Input.GetAxis ("Vertical") ;

		Vector3 tiltAmount = new Vector3 (tiltVertical, 0, tiltHorizontal);
		Quaternion rotation = Quaternion.Euler (tiltAmount);
		
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 3.5F);
	}
}
