using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	public string firstSceneName;
	public string secondSceneName;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadFirstScene(){
		SceneManager.LoadScene (firstSceneName, LoadSceneMode.Single);
	}

	public void loadSecondScene(){
		SceneManager.LoadScene (secondSceneName, LoadSceneMode.Single);
	}


}
