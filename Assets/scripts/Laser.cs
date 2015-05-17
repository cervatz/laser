using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	private LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();	
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
					print ("Enemy is hit");
					
				}
			} 
		}

	}


}
