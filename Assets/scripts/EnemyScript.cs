using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private float enemySpeed = 1;

	private GameObject player;

	void Start () {
		player = GameObject.Find (Names.PLAYER);	
	}
	
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed*Time.deltaTime);
	}
}
