using UnityEngine;
using System.Collections;

public class testGrid : MonoBehaviour {

	public static bool CanCreate = false;

	private int SpawnTestMoney;
	private int SpawnTestTNT;
	private int DontSpawn;

	public static bool GameBegin = false;

	void Start () {

		for (float x = -12f; x < 12f; x++) {
			
			for (float y = -4.5f; y < 4; y++) {
				
				
				GameObject obj = ObjectPooler.current.GetPooledObjectStart ();

				if (obj == null) {
					return;
				}
					obj.transform.position = new Vector3 (x, y, 0);
				obj.transform.rotation = transform.rotation;
				obj.SetActive(true);

			}
		}
	}

	void Update () {

		if (Input.touchCount > 0 || Input.GetKey("up")) {
			GameBegin = true;
		}
		
		if (CanCreate) {

			DontSpawn = Random.Range (-4, 4);

			for (float x = RaycastHit.RCHitX; x < 17f; x++) {
				for (float y = -4.5f; y < 4f; y++) {
					SpawnTestTNT = Random.Range (1, 21);
					SpawnTestMoney = Random.Range (1, 101);

					if (SpawnTestMoney == 10 && GameBegin == true) {
						GameObject obj = ObjectPooler.current.GetPooledObjectMoney ();
						if (obj == null) {
							return;
						}

						if (y != DontSpawn) {
							obj.transform.position = new Vector3 (x, y, 0);
						} else {
							obj.transform.position = new Vector3 (x, y+1, 0);
						}
						obj.transform.rotation = transform.rotation;
						obj.SetActive (true);
					}

					else if (SpawnTestTNT == 10 && GameBegin == true) {
						GameObject obj = ObjectPooler.current.GetPooledObjectObstacle ();
						if (obj == null) {
							return;
						}

						if (y != DontSpawn) {
							obj.transform.position = new Vector3 (x, y, 0);
						} else {
							obj.transform.position = new Vector3 (x, y+1, 0);
						}
						obj.transform.rotation = transform.rotation;
						obj.SetActive (true);

					} else {
						GameObject obj = ObjectPooler.current.GetPooledObjectStart ();

						if (obj == null) {
							return;
						}

						obj.transform.position = new Vector3 (x, y, 0);
						obj.transform.rotation = transform.rotation;
						obj.SetActive (true);
					}
				}
				CanCreate = false;
			}	
		}
	}


}
