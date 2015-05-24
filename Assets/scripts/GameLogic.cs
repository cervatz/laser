using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public void Quit() {
		print ("GameLogic Quit()");
		Application.Quit ();
	}

	public void StartGame() {
		print ("GameLogic StartGame()");
		Application.LoadLevel("laser");
	}
}