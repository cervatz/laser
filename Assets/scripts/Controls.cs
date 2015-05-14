﻿using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public int rotationSpeed;
	public int movementSpeed;
	public float friction;
	public float lerpSpeed;

	private float xDeg;
	private float yDeg;
	private Quaternion fromRotation;
	private Quaternion toRotation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PerformRotation ();
		MoveBackAndForth ();
	}

	void MoveBackAndForth() {
		if (Input.GetAxis("Vertical")!=0) {
			
			int direction = 0;
			if(Input.GetAxis("Vertical") > 0) {
				direction = 1;
			} else if(Input.GetAxis("Vertical") < 0) {
				direction = -1;
			}

			transform.Translate(Vector3.forward * Time.deltaTime * direction * movementSpeed);
		}
	}

	void PerformRotation() {
		if (Input.GetAxis("Horizontal")!=0) {
			
			int direction = 0;
			if(Input.GetAxis("Horizontal") > 0) {
				direction = 1;
			} else if(Input.GetAxis("Horizontal") < 0) {
				direction = -1;
			}
			
			xDeg += direction * rotationSpeed * friction;
			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler(0, xDeg, 0);
			
			transform.rotation = Quaternion.Lerp(fromRotation, toRotation, lerpSpeed);
			
		}
	}
}
