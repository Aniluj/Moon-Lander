using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string sceneName;

	public void ChangingScene (){
		SceneManager.LoadScene (sceneName);
	}
}
