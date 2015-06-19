using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	void Start() {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	public void Quit() {
		Application.Quit ();
	}

	public void StartGame() {
		Application.LoadLevel(Names.LASER_SCENE);
	}

	public void EndGame() {
		Application.LoadLevel(Names.MENU_SCENE);
	}

	void Update() {
		if (Input.GetKey(KeyCode.Menu)) {
			GameObject[] enemies =GameObject.FindGameObjectsWithTag(Tags.ENEMY_TAG);
			foreach(GameObject enemy in enemies) {
				Destroy(enemy);
			}
		}
	}
}