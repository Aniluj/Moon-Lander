using UnityEngine;
using UnityEngine.UI;

public class SpaceShipMovement : MonoBehaviour {

	private Rigidbody2D spaceShip;
	private float horizontalAxis;
	private float verticalAxis;
	private Transform transformOfVelocityText;
	private Text velocityText;
	private Canvas hud;
	public float totalVelocity;
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

		totalVelocity = spaceShip.velocity.magnitude * 40f;
		velocityText.text ="Velocity: "+(int)totalVelocity;
		}

	void FixedUpdate (){
		spaceShip.AddTorque (velocityOfRotation * horizontalAxis, ForceMode2D.Force);
		spaceShip.AddRelativeForce (Vector2.up * velocityInY * verticalAxis, ForceMode2D.Force);

	}
}
