using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

	public static ObjectPooler current;

	public GameObject Dirt;
	public GameObject Tnt;
	public GameObject Money;

	public int PooledAmount = 250;
	public int PooledAmountObstacles = 40;
	public int PooledAmountMoney = 100;

	public bool WillGrow = true;

	public List<GameObject> PooledObjects;
	public List<GameObject> PooledObstacles;
	public List<GameObject> PooledMoney;

	void Awake(){
		current = this;
	}

	void Start () {

		PooledObjects = new List<GameObject> ();
		PooledObstacles = new List<GameObject> ();

		for (int i = 0; i < PooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (Dirt);
			obj.SetActive (false);
			PooledObjects.Add (obj);
		}
		for (int i = 0; i < PooledAmountObstacles; i++) {
			GameObject obj = (GameObject)Instantiate (Tnt);
			obj.SetActive (false);
			PooledObstacles.Add (obj);
		}
		for (int i = 0; i < PooledAmountMoney; i++) {
			GameObject obj = (GameObject)Instantiate (Money);
			obj.SetActive (false);
			PooledMoney.Add (obj);
		}
	
	}

	public GameObject GetPooledObjectStart(){//GameObjects de base
		for (int i = 0; i < PooledObjects.Count; i++) {
			if (!PooledObjects [i].activeInHierarchy) {
				return PooledObjects [i];
			}
		}

		if (WillGrow) { //Si la liste peuyt grossir
			GameObject obj = (GameObject)Instantiate (Dirt);
			PooledObjects.Add (obj);
			return obj;
		}
		return null;
	}

	public GameObject GetPooledObjectObstacle(){//GameObject Obstacle (TNT)
		for (int i = 0; i < PooledObstacles.Count; i++) {
			if (!PooledObstacles [i].activeInHierarchy) {
				return PooledObstacles [i];
			}
		}


		return null;
	}

	public GameObject GetPooledObjectMoney(){//GameObject Obstacle (TNT)
		for (int i = 0; i < PooledMoney.Count; i++) {
			if (!PooledMoney [i].activeInHierarchy) {
				return PooledMoney [i];
			}
		}


		return null;
	}

}
