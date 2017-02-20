using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {

	void Start ()
	{
		Light mat = GetComponent<Light> ();
		if (mat) 
		{
			float r = RandomColorValue (),
				  g = RandomColorValue (),
				  b = RandomColorValue ();
			mat.color = new Color (r, g, b);
		}
	}

	float RandomColorValue()
	{
		return Random.Range (0.0F, (150.0F / 255.0F));
	}

	void Update () 
	{
		DoRotation ();
	}

	void DoRotation ()
	{
		Vector3 rotationMagnitude = Vector3.up * 30;
		transform.Rotate (rotationMagnitude * Time.deltaTime);
	}

	public bool PickupAndKill ()
	{
		gameObject.SetActive (false);
		return true;
	}
}
