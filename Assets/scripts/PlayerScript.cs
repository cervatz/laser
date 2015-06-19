using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	private GameObject logicContainer;

	private GameLogic gameLogic;

	void Start() {
		logicContainer = GameObject.Find("LogicContainer");

		gameLogic = logicContainer.GetComponent<GameLogic>();
	}

	void OnCollisionEnter(Collision collision) {
		print("collision");
		if (collision.collider.CompareTag (Tags.ENEMY_TAG)) {
			gameLogic.EndGame();
		}
	}
}
