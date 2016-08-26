using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static float score;

	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (!Buttons.pause) {
			score = score + 0.1f;
			text.text = Mathf.Round (score) + " m";
		}
	}
}
