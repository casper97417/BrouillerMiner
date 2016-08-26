using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

	public static int Money;

	Text text;

	void Awake () {
		text = GetComponent<Text> ();
		Money = 0;
	}

	void Update () {
		text.text = "Money : " + Money;
	}
}
