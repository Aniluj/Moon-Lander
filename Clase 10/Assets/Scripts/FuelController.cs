using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour {

	public Slider fuel;
	public float fuelLost;

	void Start () {
		fuel.value = 10f;
	}

	void Update () {
		if(Input.GetButton("Vertical")){
			fuel.value -= fuelLost;
		}
	}


}
