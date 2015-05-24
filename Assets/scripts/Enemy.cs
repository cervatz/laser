using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float enemySpeed;

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed*Time.deltaTime);
	}
}
