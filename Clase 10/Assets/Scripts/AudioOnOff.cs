using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnOff : MonoBehaviour {

	private int onOff;
	private string audioState = "audioState";

	void Start () {
		onOff = PlayerPrefs.GetInt (audioState, 0);
	}

	public void AudioPref (){
		PlayerPrefs.SetInt (audioState, OnOff(ref onOff));
	}

	public int OnOff (ref int state) {
		if (state == 1) {
			Debug.Log ("Entró, perro");
			state = 0;
			AudioListener.pause = false;
		}else if (state == 0){
			Debug.Log ("Entró, wachín");
			state = 1;
			AudioListener.pause = true;
		}
		return state;
	}
}