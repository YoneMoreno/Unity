using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_B : MonoBehaviour {
	private int enemyDistance = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("space")) {
			EnemySearch ();
		}
	}

	void EnemySearch(){
		for (int i = 0; i < 5; i++) {
			enemyDistance = Random.Range (1, 10);
			if (enemyDistance>=8) {
				print ("An enemy is far away");
			}
			if (enemyDistance>=4&&enemyDistance<=7) {
				print ("The enemy is at medium range");
			}
			if (enemyDistance<4) {
				print ("An enemy IS VERY CLOSE");
			}
		}
	}
}
