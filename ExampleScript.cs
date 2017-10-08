using System.Collections; //It access the namespace like packages in Java
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour { //It is extending from MonoBehaviour so it brings start and update
	//Class lets organize agrouping, it is the exact same name as the file one
	//We can use inheritance and composition
	//We know we are inheritating because of :
	// Use this for initialization
	//Accesor allow other class to get info of this variable

	/*
	 Assignment operators:
	 = 
	 += speed = speed + y (speed+=y)
	 -=
	 *=
	 *=
	 %= 7 % 3 = 1
	Arithmetic operators:
	+
	-
	*
	/
	%


	Comparison Operathors:
	== Is equal to
	!= Not equal to
	>
	<

	Logical operators:
	&& and
	|| or
	! not
	 */



	public float speed = 0.0f;
	public float distance = 0.0f;
	public float time = 0.0f;

	float maxSpeedLimit = 70.0f;
	float minSpeedLimit = 40.0f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			SpeedCheck();
		}
	}

	void SpeedCheck(){
		speed = distance / time;
		if (speed > maxSpeedLimit) {
			{
				print ("You are exceeding the speed limit");				
			}
			if (speed < minSpeedLimit)
			{
				print("You are a turtle");
			}
			if (speed == maxSpeedLimit || speed == minSpeedLimit) {
				print ("You are very close to the LIMITS");
			}
			else {
				print("You are into the limit");
			}
		}
	}
}
