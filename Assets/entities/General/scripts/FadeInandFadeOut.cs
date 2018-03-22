﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class FadeInandFadeOut : MonoBehaviour {
	public float fadeInTime;
	
	private Image fadePanel;
	private Color currentColor;
	
	// Use this for initialization
	// SceneManager.LoadScene
	//
	void Start () {
		fadePanel = GetComponent<Image>();
		if(SceneManager.GetActiveScene().name == "00 Splash"){
			currentColor = Color.white;
		}
		else{
			currentColor = Color.black;
		}
	}
	
	// Update is called once per frame
	void Update () {
		fadeFunction(SceneManager.GetActiveScene().name);
	}
	
	void fadeFunction(string typeOfFade){
	//	Color currentColor;
		if(typeOfFade == "01 Start"){
			if(Time.timeSinceLevelLoad < fadeInTime){
				float alphaChange = Time.deltaTime / fadeInTime;
				currentColor.a -= alphaChange;
				fadePanel.color = currentColor;
			}
			else {
				gameObject.SetActive (false);
			}
		}
		else{
			if(Time.timeSinceLevelLoad < fadeInTime/2){
				float alphaChange = Time.deltaTime / (fadeInTime/2);
				currentColor.a -= alphaChange;
				fadePanel.color = currentColor;
			}
			else{
				float alphaChange = Time.deltaTime / (fadeInTime/2);
				currentColor.a += alphaChange;
				fadePanel.color = currentColor;
			}
		}
	}
}
