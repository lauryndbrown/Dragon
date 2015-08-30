using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    float delayNextLevel = 3;

	void Start(){
		Invoke ("LoadNextLevel", delayNextLevel);
	}

	public void LoadLevel(string name){
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel (name);
	}
	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	public void QuitRequest()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}

