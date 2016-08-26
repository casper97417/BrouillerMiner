using UnityEngine;
using System.Collections;

public class TouchDrag : TouchSprite {

	public bool Test = true;

	void Update () {
		TouchInput ();
	}

	void OnFirstTouch(){
		
		Vector3 pos;
		if (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y >= transform.position.y - 1.5f && Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y <= transform.position.y + 1.5f) {
			if (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y <= 3.5 && Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y >= -4.5) {

				pos = new Vector3 (transform.position.x, (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y), transform.position.z);
				transform.position = pos;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Respawn")
			Test = false;
	}
}
