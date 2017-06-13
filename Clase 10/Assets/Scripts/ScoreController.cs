using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	private int score = 0;

	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.CompareTag ("PointOfLanding")) {
			score += col.gameObject.GetComponent<ValueOfLanding> ().value;
			Debug.Log (score);
		}
	}
}
