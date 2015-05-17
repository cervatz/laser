using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	public GameObject enemy;

	private float planeDiameter = 15.0f;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("InstantiateEnemy", 2, 1);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void InstantiateEnemy() {
		Vector3 enemyPosition = new Vector3(Random.Range(-planeDiameter, planeDiameter), 0.5f, Random.Range(-planeDiameter, planeDiameter));
		Instantiate (enemy, enemyPosition, Quaternion.identity);
	}

}
