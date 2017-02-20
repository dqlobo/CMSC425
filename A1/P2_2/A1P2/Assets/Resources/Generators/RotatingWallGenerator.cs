using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWallGenerator : MonoBehaviour {
	public uint diameter;



	// Use this for initialization
	void Start () 
	{
		float radius = diameter / 2.0F,
			squareSize = diameter / 10.0F;
		Vector3 gridOffset = radius * (Vector3.forward + Vector3.left);
//		int j = 0;
		for (int i = 1; i < 10; i++) {
			Vector3 evenOffset = (1 - i % 2) * Vector3.right * squareSize;
			Vector3 wallPosition = Vector3.right
			                       + evenOffset
			                       + gridOffset
			                       + squareSize * Vector3.right + squareSize * i * Vector3.back;
			float maxPosition = gridOffset.x + diameter;
			while (wallPosition.x < maxPosition) {

				if (i == 5  && wallPosition.x == 1) 
					break;

				Quaternion wallRotation = Quaternion.AngleAxis (0, Vector3.zero);
				GameObject newWall = (GameObject)Instantiate (
									Resources.Load ("Prefabs/RotatingWall"), 
									wallPosition,
									wallRotation
								);
				newWall.transform.SetParent (transform);	
				wallPosition += 2 * squareSize * Vector3.right;
			}

		}
	}

}
