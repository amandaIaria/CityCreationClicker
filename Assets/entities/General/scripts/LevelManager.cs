using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {
	
	public float autoLoadNextLevelAfter;
	
	void Start(){
		if(SceneManager.GetActiveScene().name == "00 Splash"){
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}
	
	public void LoadLevel(string name){
		SceneManager.LoadScene(name);
	}
	public void QuitRequest(){
		Application.Quit();
	}
	public void LoadNextLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
}