using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCondition : MonoBehaviour {

	public float maxCorrectRotation;
	public float minCorrectRotation;

	void OnCollisionEnter2D(Collision2D col){
		
		if (transform.rotation.eulerAngles.z > maxCorrectRotation) {
			Debug.Log(transform.rotation.z);
		}
	}
}
