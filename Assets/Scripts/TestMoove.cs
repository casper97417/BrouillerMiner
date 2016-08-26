using UnityEngine;
using System.Collections;

public class TestMoove : MonoBehaviour {


	void LateUpdate () {

		
		this.transform.Translate (Vector3.left * Time.deltaTime * PlayerCollider.Speed);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "test") {
			this.gameObject.SetActive (false);
		}

	}
}
