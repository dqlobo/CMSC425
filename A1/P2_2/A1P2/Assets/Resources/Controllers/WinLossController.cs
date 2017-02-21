using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLossController : MonoBehaviour {
	

	public Text textLabel;

	public void SetWinningState () 
	{
		textLabel.text = "Congratulations! You Win!";
	}

	public void SetLosingState ()
	{
		textLabel.color = Color.red;
		textLabel.text = "Boo! You Lose!";
	}

	void Start ()
	{
		textLabel.text = "";
	}

}
