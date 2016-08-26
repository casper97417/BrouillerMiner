using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour {

	public static AsyncOperation GameOver;

	public static float Speed = 8f;

	private float PlayerSpeed = 2f;

	void Update () {
		if(Speed <= 7f)
		Speed = Speed + 0.001f;
		//this.transform.Translate (Vector3.up * Time.deltaTime * PlayerSpeed);
		if(Input.GetKey("up")){
			this.transform.Translate (Vector3.up * Time.deltaTime * PlayerSpeed);
		}
		if(Input.GetKey("down")){
			this.transform.Translate (Vector3.down * Time.deltaTime * PlayerSpeed);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Finish")
			col.gameObject.SetActive (false);
		else if (col.gameObject.tag == "Money") {
			MoneyManager.Money++;
			col.gameObject.SetActive (false);
		}
		else if (col.gameObject.tag == "TNT") {
			col.gameObject.SetActive (false);
			GameOver = SceneManager.LoadSceneAsync (1, LoadSceneMode.Single);
		}
	}



}
