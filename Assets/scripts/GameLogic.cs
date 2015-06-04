using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public void Quit() {
		Application.Quit ();
	}

	public void StartGame() {
		Application.LoadLevel(Names.LASER_SCENE);
	}

	public void EndGame() {
		Application.LoadLevel(Names.MENU_SCENE);
	}
}