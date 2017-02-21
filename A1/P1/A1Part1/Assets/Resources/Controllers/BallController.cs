using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();	
	}
	
	void Update () {
		if (Input.GetKeyUp (KeyCode.Q)) {
			Application.Quit ();
		}
		if (Input.GetKeyUp (KeyCode.R)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Finish")) {
			Vector3 upForce = new Vector3 (0, 10000, 0);
			rb.AddForce (upForce);
			rb.useGravity = false;
		}
	}

}
