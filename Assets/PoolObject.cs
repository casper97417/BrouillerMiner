using UnityEngine;
using System.Collections;

public class PoolObject : MonoBehaviour {

	public float createTime = 2f;

	void Create(){

		GameObject obj = ObjectPooler.current.GetPooledObjectStart ();

		if (obj == null)
			return;

		obj.transform.position = new Vector3 (0, 0, 0);
		obj.transform.rotation = transform.rotation;
			obj.SetActive(true);

		createTime = 10f;

	}
}
