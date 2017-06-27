using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {

	public GameObject victoryPanel;
	public int scoreOfVictory;
	public Transform startingPoint;
	private SpaceShipMovement movement;
	private int score = 0;
	private float rotationZ;
	private Life useOfMinAndMax;
	private Canvas hud;
	private Transform transformOfText;
	private Text scoreText;

	void Awake (){
		movement = GetComponent<SpaceShipMovement> ();
		useOfMinAndMax = GetComponent<Life> ();
		hud = transform.GetComponentInChildren<Canvas> ();
	}

	void Start (){
		transformOfText = hud.transform.Find ("Score");
		scoreText = transformOfText.GetComponent<Text> ();
	}

	void Update () {
		scoreText.text = "Score: " + score;
		if (score >= scoreOfVictory) {
			movement.enabled = false;
			transform.position = startingPoint.position;
			transform.rotation = startingPoint.rotation;
			victoryPanel.SetActive (true);
			if(Input.GetButton("Restart")){
				SceneManager.LoadScene ("Moon Lander");
			}
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		rotationZ = transform.eulerAngles.z;

		if (col.gameObject.CompareTag ("PointOfLanding") && (rotationZ < useOfMinAndMax.maxCorrectRotation || rotationZ > useOfMinAndMax.minCorrectRotation)) {
			score += col.gameObject.GetComponent<ValueOfLanding> ().value;
		}
	}
}
