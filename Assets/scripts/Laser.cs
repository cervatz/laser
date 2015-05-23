using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Laser : MonoBehaviour {
	
	private LineRenderer lineRenderer;

	public Text score;
	private int counter = 0;

	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();	
//		score.text = "Score: " + counter;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump")) {
			lineRenderer.enabled = true;
			Fire ();
		} else {
			lineRenderer.enabled = false;
		}
	}
	
	void Fire() {

		lineRenderer.SetPosition (1, new Vector3 (0, 0, 5000));

		RaycastHit hit;

		if (Physics.Raycast (transform.position, transform.forward, out hit)) {

			if(hit.collider) {
				lineRenderer.SetPosition (1, new Vector3 (0, 0, hit.distance));

				if(hit.collider.tag == "Enemy")
				{
					AudioSource audio = GetComponent<AudioSource>();
					audio.Play();
					Destroy(hit.collider.gameObject);

					counter += 1;
					score.text = "Score: " + counter;


				}
			} 
		}
	}

	void IncreaseScore() {
	}


}
