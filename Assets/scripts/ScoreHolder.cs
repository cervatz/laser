using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreHolder : MonoBehaviour {

	private static int scoreAmount = 0;

	public GameObject scoreObject;

	private string SCORE_PREFIX = "Score: ";

	// Use this for initialization
	void Start () {
		IncreaseScore (10);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void IncreaseScore(int increase) {
		Text textValue = scoreObject.GetComponent<Text>();
		textValue.text = SCORE_PREFIX + (scoreAmount += increase);
	}
}