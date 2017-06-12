using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour {

	private Rigidbody2D spaceShip;
	private float horizontalAxis;
	private float verticalAxis;
	public float velocityInY = 0f;
	public float velocityOfRotation = 0f;

	void Awake(){
		spaceShip = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		horizontalAxis = Input.GetAxisRaw ("Horizontal");
		verticalAxis = Input.GetAxis ("Vertical");
	}

	void FixedUpdate (){
		spaceShip.AddTorque (velocityOfRotation * horizontalAxis, ForceMode2D.Force);
		spaceShip.AddRelativeForce (Vector2.up * velocityInY * verticalAxis, ForceMode2D.Force);
	}
}
