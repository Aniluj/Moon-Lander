using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCondition : MonoBehaviour {

	public float maxCorrectRotation;
	public float minCorrectRotation;
	private float rotationZ;

	void OnCollisionEnter2D(Collision2D col){
		
		rotationZ = transform.eulerAngles.z;

		Debug.Log (rotationZ);
		if (rotationZ > 4.5 && rotationZ < 356) {
			Debug.Log ("Perdiste");
		}
	}
	void OnCollisionExit2D(Collision2D col2){
		rotationZ = 0f;
	}
}
