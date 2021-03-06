﻿using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour {

	public float speedToDestination;

	private Vector3 destination = Vector3.zero;

	private GameObject player;

	private GameObject aimInstance;

	// Use this for initialization
	void Start () {
		GameObject aimPrefab = (GameObject) Resources.Load(Names.AIM_PREFAB);
		aimInstance = (GameObject) Instantiate (aimPrefab, new Vector3(0f, Constants.Y, 0f), Quaternion.identity);

		player = GameObject.Find (Names.PLAYER);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				GameObject recipient = hit.transform.gameObject;
				if(recipient.CompareTag(Tags.ENEMY_TAG)) {
					print(recipient.name);
					Destroy(recipient);
				} else if(recipient.CompareTag(Tags.PLANE_TAG)) {
					destination = new Vector3(hit.point.x, Constants.Y, hit.point.z);
					PlaceAim(destination);
				}
			}
		}

		Move ();
	}

	void PlaceAim(Vector3 position) { 
		aimInstance.transform.position = position;
	}

	void Move() {
		if (aimInstance.transform.position != player.transform.position) {
			player.transform.position = Vector3.MoveTowards (player.transform.position, destination, speedToDestination * Time.deltaTime);
		}
	}

	void LateUpdate() {
		if (transform.position == destination) {
			destination = Vector3.zero;
		}
	}
}
