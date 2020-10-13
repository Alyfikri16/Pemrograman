using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	public void MenuScene(){
		SceneManager.LoadScene ("Menu");
	}
		
	public void LoadingScene(){
		SceneManager.LoadScene ("Loading");
	}
		
	public void KeluarScene(){
		Application.Quit ();
	}
	// Use this for initialization
	void Start (){ 
	}
	
	// Update is called once per frame
	void Update () {
	
}
}