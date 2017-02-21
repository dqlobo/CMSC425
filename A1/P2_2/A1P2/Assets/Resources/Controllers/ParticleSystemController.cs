using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour {

	void Update () {
		transform.rotation = Quaternion.AngleAxis (0, Vector3.up);
	}
}
