using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public static AsyncOperation NewGame;

	public static bool pause = false;

	public GameObject PauseButton;
	public GameObject PlayCurrentButton;

	public void PauseCurrentGame(){
		Time.timeScale = 0;
		pause = true;
		PauseButton.SetActive (false);
		PlayCurrentButton.SetActive (true);
	}

	public void ResumeCurrentGame(){
		Time.timeScale = 1;
		pause = false;
		PlayCurrentButton.SetActive (false);
		PauseButton.SetActive (true);
	}

	public void Recommencer(){
		NewGame = SceneManager.LoadSceneAsync (0, LoadSceneMode.Single);
	}
}
