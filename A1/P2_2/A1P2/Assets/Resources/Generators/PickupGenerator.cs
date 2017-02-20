using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGenerator : MonoBehaviour {
	public int count; // default is 5
	GameObject[] pickups;

	void Start () 
	{
		if (count <= 0) 
			count = 5;
		pickups = new GameObject[count];
		Vector3 yPosition = Vector3.up * 0.5F;
		HashSet<Vector3> spacesTaken = new HashSet<Vector3> ();
		spacesTaken.Add (
			Vector3.right * 9
			+ Vector3.forward * 9
			+ yPosition
		);

		for (int i = 0; i < pickups.Length; i++) 
		{
			
			GameObject newPickup = (GameObject) Instantiate (Resources.Load ("Prefabs/Pickup"));
			newPickup.transform.SetParent (transform);
			do {
				Vector3 xPosition = Vector3.right * generateRandomOddNumber ();
				Vector3 zPosition = Vector3.forward * generateRandomOddNumber ();
				newPickup.transform.position = xPosition + yPosition + zPosition;
			} while (spacesTaken.Contains (newPickup.transform.position));
			spacesTaken.Add(newPickup.transform.position);
			pickups [i] = newPickup;
		}
	}

	int generateRandomOddNumber ()
	{
		int output = Random.Range (-9, 10);
		return output % 2 != 0 ? output : output + 1;
	}

	void Update () {
		
	}
}
