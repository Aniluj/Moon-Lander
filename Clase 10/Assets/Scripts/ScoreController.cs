using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int score = 0;
	private float rotationZ;
	private VictoryCondition useOfMinAndMax;
	private Transform hud;
	private Transform transformOfText;
	private Text scoreText;

	void Awake (){
		useOfMinAndMax = GetComponent<VictoryCondition> ();
	}

	void Start (){
		hud = transform.Find ("Canvas");
		transformOfText = hud.Find ("Score");
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
