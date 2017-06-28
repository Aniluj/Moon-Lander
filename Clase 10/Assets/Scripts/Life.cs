using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour {

	public float maxCorrectRotation;
	public float minCorrectRotation;
	public float maxVelocity;
	public Transform startingPosition;
	public int life;
	public GameObject defeatPanel;
	private FuelController fuel;
	private Renderer spaceshipRenderer;
	private SpaceShipMovement movement;
	private float rotationZ;
	private Canvas hud;
	private Transform transformOfLifeText;
	private Text lifeText;

	void Awake (){
		fuel = GetComponent<FuelController> ();
		movement = GetComponent<SpaceShipMovement> ();
		spaceshipRenderer = GetComponent<Renderer> ();
		hud = transform.GetComponentInChildren<Canvas> ();
	}

	void Start(){
		life = 3;
		transformOfLifeText = hud.transform.Find ("Spaceship Lifes");
		lifeText = transformOfLifeText.GetComponent<Text> ();
	}

	void Update(){

		lifeText.text = "Life: " + life;

		if (life == 0 || fuel.fuel.value <= 0) {
			fuel.fuel.gameObject.SetActive (false);
			spaceshipRenderer.enabled = false;
			movement.enabled = false;
			transform.position = startingPosition.position;
			defeatPanel.SetActive (true);
			if (Input.GetButton ("Restart")) {
				SceneManager.LoadScene ("Moon Lander");
			}	
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		
		rotationZ = transform.eulerAngles.z;

		if ((rotationZ > maxCorrectRotation && rotationZ < minCorrectRotation) || movement.totalVelocity >= maxVelocity) {
			life--;
			gameObject.SetActive (false);
			transform.rotation = startingPosition.rotation;
			transform.position = startingPosition.position;
			gameObject.SetActive (true);
		}
	}

	void OnCollisionStay2D(Collision2D col2){

		rotationZ = transform.eulerAngles.z;

		if ((rotationZ > maxCorrectRotation && rotationZ < minCorrectRotation) || movement.totalVelocity >= maxVelocity) {
			life--;
			gameObject.SetActive (false);
			transform.rotation = startingPosition.rotation;
			transform.position = startingPosition.position;
			gameObject.SetActive (true);
		}
	}

	void OnCollisionExit2D(Collision2D col3){
		rotationZ = 0f;
	}

	void OnTriggerEnter2D(Collider2D colli1){

		rotationZ = transform.eulerAngles.z;

		if ((rotationZ > maxCorrectRotation && rotationZ < minCorrectRotation) || movement.totalVelocity >= maxVelocity) {
			life--;
			gameObject.SetActive (false);
			transform.rotation = startingPosition.rotation;
			transform.position = startingPosition.position;
			gameObject.SetActive (true);
		}
	}
}