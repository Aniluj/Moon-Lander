using UnityEngine;

public class ChangePanel : MonoBehaviour {

	public GameObject menuPanel;
	public GameObject creditsPanel;

	public void ChangingOfPanel (){
		if (menuPanel.activeInHierarchy) {
			menuPanel.SetActive (false);
			creditsPanel.SetActive (true);
		} else {
			creditsPanel.SetActive (false);
			menuPanel.SetActive (true);
		}
	}
}
