using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int score = 0;
	private float rotationZ;
	private Life useOfMinAndMax;
	private Canvas hud;
	private Transform transformOfText;
	private Text scoreText;

	void Awake (){
		useOfMinAndMax = GetComponent<Life> ();
		hud = transform.GetComponentInChildren<Canvas> ();
	}

	void Start (){
		transformOfText = hud.transform.Find ("Score");
		scoreText = transformOfText.GetComponent<Text> ();
	}

	void Update () {
		scoreText.text = "Score: " + score;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		rotationZ = transform.eulerAngles.z;

		if (col.gameObject.CompareTag ("PointOfLanding") && (rotationZ < useOfMinAndMax.maxCorrectRotation || rotationZ > useOfMinAndMax.minCorrectRotation)) {
			score += col.gameObject.GetComponent<ValueOfLanding> ().value;
		}
	}
}
