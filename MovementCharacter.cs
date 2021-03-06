using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovementCharacter : MonoBehaviour {

	public float moveForce = 20;
	Rigidbody Mybody;

	// Use this for initialization
	void Start () {
		Mybody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Vector3 moveVector = new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;

		Mybody.AddForce (moveVector * moveForce);

	}
}
