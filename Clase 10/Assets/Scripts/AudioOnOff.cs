using UnityEngine;
using UnityEngine.UI;

public class AudioOnOff : MonoBehaviour {

	private int onOff;
	private Text textOfAudioState;
	private string audioState = "audioState";

	void Start () {
		textOfAudioState = GetComponentInChildren<Text> ();
		onOff = PlayerPrefs.GetInt (audioState, 0);
		if (onOff == 1) {
			textOfAudioState.text = "Audio: Off";
		} else if (onOff == 0) {
			
			textOfAudioState.text = "Audio: On";
		}
	}

	public void AudioPref (){
		PlayerPrefs.SetInt (audioState, OnOff(ref onOff));
	}

	public int OnOff (ref int state) {
		if (state == 1) {
			state = 0;
			AudioListener.pause = false;
			textOfAudioState.text = "Audio: On";
		}else if (state == 0){
			state = 1;
			AudioListener.pause = true;
			textOfAudioState.text = "Audio: Off";
		}
		return state;
	}
}