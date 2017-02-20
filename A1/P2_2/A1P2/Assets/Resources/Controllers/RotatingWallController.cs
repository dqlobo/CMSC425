using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWallController : MonoBehaviour {


	Vector3 pivot;
	float rotationAngle,
	targetAngle;
	void Start () 
	{		
				
		transform.position = transform.position + 0.5F * Vector3.up;
		pivot = transform.InverseTransformPoint(transform.position - Vector3.right);
		targetAngle = 0;
		rotationAngle = 0;
		RotateRandomly (false);
	}

	// Update is called once per frame
	void Update () 
	{
		PivotWall ();
	}

	void PivotWall ()
	{
		if (rotationAngle != 0) {
			ContinueRotating ();	
		} else if (Random.Range (0, 2500) < 10) {
			rotationAngle = 90 * GetRandomDirection ();			
		}	
	}

	void ContinueRotating ()
	{
		RotateRandomly (true);
		if (Mathf.Abs(targetAngle) >= 90) {
			targetAngle = 0;
			rotationAngle = 0;
		}
	}

	void RotateRandomly(bool animated) {
		// if animated, continue an existing animation, else snap a rotation
		float degree = 90 * GetRandomDirection ();
		if (animated) {
			targetAngle += targetAngle <= 90 ? rotationAngle * Time.deltaTime : 90 - targetAngle;

			degree = rotationAngle * Time.deltaTime;
		}
		transform.RotateAround (
			transform.TransformPoint (pivot), // rotate around far left pivot of wall in Global Coordinates
			transform.TransformDirection (Vector3.up),
			degree
		);
	}
	int GetRandomDirection () 
	{
		return Random.Range (-1,2);
	}
}
