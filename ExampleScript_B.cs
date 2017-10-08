using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_B : MonoBehaviour {
	private int enemyDistance = 0;
	private int enemyCount = 10;

	private string[] enemies = new string[5];
	private int weaponId = 0;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("space")) {
			//EnemySearch ();
			//EnemyDestruction();
			//EnemyScan();
			//EnemyRoster();
			WeaponSearch();
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

	void EnemyDestruction(){
		while (enemyCount > 0) {
			print ("There is an enemy Lets destroy it");
			enemyCount--;
		}
	}

	void EnemyScan(){
		bool isAlive = false;

		do {
			print("Scanning for enemies");
		} while (isAlive == true);
	}

	void EnemyRoster(){
		enemies [0] = "orc";
		enemies [1] = "dragon";
		enemies [2] = "elf";
		enemies [3] = "baby";
		enemies [4] = "clown";

		foreach (string enemy in enemies) {
			print (enemy);
		}
	}

	void WeaponSearch(){
		weaponId = Random.Range (0, 10);
		switch (weaponId) {
		case 1:
			print("You found a sword");
			break;
		case 2:
			print("You found an axe");
			break;
		case 3:
			print("You found a block");
			break;
		case 4:
			print("You found a dagger");
			break;
		default:
			print("You found a nothing ;)");
			break;

		}
	
	}

}




