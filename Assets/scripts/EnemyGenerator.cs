using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	private GameObject enemyPrefab;

	private float planeDiameter = 15.0f;

	// Use this for initialization
	void Start () {
		enemyPrefab = (GameObject) Resources.Load(Names.ENEMY_PREFAB);

		InvokeRepeating("InstantiateEnemy", 2, 1);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void InstantiateEnemy() {
		Vector3 enemyPosition = new Vector3(Random.Range(-planeDiameter, planeDiameter), 0.5f, Random.Range(-planeDiameter, planeDiameter));
		Instantiate (enemyPrefab, enemyPosition, Quaternion.identity);
	}

}
