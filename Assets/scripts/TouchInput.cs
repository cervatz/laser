using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour {

	public float speedToDestination;

	private Vector3 destination = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				GameObject recipient = hit.transform.gameObject;
				if(recipient.CompareTag("Enemy")) {
					print(recipient.name);
					Destroy(recipient);
				} else if(recipient.CompareTag("Plane")) {
					destination = new Vector3(hit.point.x, 0.5f, hit.point.z);
				}
			}
		}

		Move ();

	}

	void Move() {
		if (destination != Vector3.zero) {
			transform.position = Vector3.MoveTowards (transform.position, destination, speedToDestination * Time.deltaTime);
		}
	}

	void LateUpdate() {
		if (transform.position == destination) {
			destination = Vector3.zero;
		}
	}



}
