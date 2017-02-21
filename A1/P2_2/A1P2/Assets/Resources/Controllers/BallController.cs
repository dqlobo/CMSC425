using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	public Rigidbody rb;
	public GameObject scoreText;
	public GameObject winLossState;
	ScoreController sc;
	WinLossController wlc;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		sc = scoreText.GetComponent<ScoreController> ();
		wlc = winLossState.GetComponent<WinLossController> ();
	}
	
	void Update () 
	{
		RegisterControls ();
		if (transform.position.y < -20) 
		{
			wlc.SetLosingState ();
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Finish")) 
		{
			EnterFinishedState ();
		}
		else if (other.gameObject.CompareTag ("Pickup")) 
		{
			PickupController controller = other.gameObject.GetComponent<PickupController> ();
			sc.IncrementScore ();			
			DoPickup(controller);			
		}
	}
	// ---
	// trigger response
	// ---
	void EnterFinishedState ()
	{
		if (sc.IsComplete ()) {
			Vector3 upForce = new Vector3 (0, 10000, 0);
			rb.AddForce (upForce);
			rb.useGravity = false;
			wlc.SetWinningState ();
		}
	}

	void DoPickup (PickupController controller)
	{		
		if (!controller)
			return;
		
		controller.PickupAndKill ();
	}

	// ---
	// input controls
	// ---
	void RegisterControls () 
	{
		SetGlobalControls ();
		SetBallControls ();
	}

	void SetBallControls () {
		if (Input.GetKeyUp (KeyCode.Space))
		{
			Vector3 jumpForce = Vector3.up * 1000;
			rb.AddForce (jumpForce);

		}
	}
	void SetGlobalControls ()
	{
		if (Input.GetKeyUp (KeyCode.Q)) 
		{
			Application.Quit ();
		}
		if (Input.GetKeyUp (KeyCode.R))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
	}
}
