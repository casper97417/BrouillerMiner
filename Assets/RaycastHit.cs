using UnityEngine;
using System.Collections;


public class RaycastHit : MonoBehaviour {

	public Renderer rend;

	public static float RCHitX;
	void Start () {

		RCHitX = this.transform.position.x + 0.4f;
	}

	void FixedUpdate () {
		Vector3 DO = transform.TransformDirection (Vector3.down) * 10;

		if (Physics2D.Raycast (transform.position, DO, 10)) {
			//Debug.DrawRay (transform.position, DO, Color.green);

		} else {
			//Debug.DrawRay (transform.position, DO, Color.red);
			testGrid.CanCreate = true;
		}
	}
}
