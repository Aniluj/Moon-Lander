using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipMovement : MonoBehaviour {

	private Rigidbody2D spaceShip;
	private float horizontalAxis;
	private float verticalAxis;
	private float totalVelocity;
	private Transform transformOfVelocityText;
	private Text velocityText;
	private Canvas hud;
	public float velocityInY = 0f;
	public float velocityOfRotation = 0f;

	void Awake(){
		hud = transform.GetComponentInChildren<Canvas> ();
		spaceShip = GetComponent<Rigidbody2D> ();
	}

	void Start(){
		transformOfVelocityText = hud.transform.Find ("Velocity");
		velocityText = transformOfVelocityText.GetComponent<Text> ();
	}

	void Update () {
		horizontalAxis = Input.GetAxisRaw ("Horizontal");
		verticalAxis = Input.GetAxis ("Vertical");
		if (verticalAxis > 0) {
			totalVelocity = spaceShip.velocity.magnitude * 40f;
		} else {
			totalVelocity -= spaceShip.velocity.magnitude * 40f;
		}
		velocityText.text ="Velocity: "+(int)totalVelocity;
		if (totalVelocity <= 0f) {
			velocityText.text = "Velocity: " + 0;
		}
	}

	void FixedUpdate (){
		spaceShip.AddTorque (velocityOfRotation * horizontalAxis, ForceMode2D.Force);
		spaceShip.AddRelativeForce (Vector2.up * velocityInY * verticalAxis, ForceMode2D.Force);

	}
}