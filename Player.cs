using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public CapsuleCollider playerCollider;

	float moveSpeed = 5f;

	// Use this for initialization
	void Start () {
		playerCollider = GetComponent<CapsuleCollider> ();
		playerCollider.height = 1f;
		playerCollider.center = new Vector3 (0, -0.25f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorziontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorziontal, 0f, moveVertical);

		transform.Translate (movement * Time.deltaTime * moveSpeed);

	}
}
