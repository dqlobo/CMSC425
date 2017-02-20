using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	const uint TARGET_SCORE = 2;
    uint score;
	Text scoreLabel;

	// Use this for initialization

	public void IncrementScore ()
	{
		if (!IsComplete ())
			score--;
	}

	public bool IsComplete ()
	{
		return score == 0;
	}

	void Start () 
	{
		score = TARGET_SCORE;
		scoreLabel = GetComponent<Text> ();
	}
	
	void Update ()
	{
		if (IsComplete ()) 
		{
			scoreLabel.text = "Done, Go to the goal!";
			scoreLabel.color = Color.yellow;
		} else
		{
			scoreLabel.text = "Pickups Remaining: " + score;
		}
	}
}
