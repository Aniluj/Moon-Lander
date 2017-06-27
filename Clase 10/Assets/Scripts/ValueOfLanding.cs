using UnityEngine;

public class ValueOfLanding : MonoBehaviour {

	public int value;
	public float rechargeOfFuel;

	void OnTriggerEnter2D (Collider2D colSpaceShip)
	{
		if (colSpaceShip.gameObject.name == "Space Ship") {
			gameObject.SetActive (false);
		}	
	}
}
