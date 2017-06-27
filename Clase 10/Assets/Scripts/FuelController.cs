using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour {

	public Slider fuel;

	void Start () {
		fuel.value = 10f;
	}

	void Update () {
		if(Input.GetButton("Vertical")){
			fuel.value -= 0.015f;
		}
	}


}
