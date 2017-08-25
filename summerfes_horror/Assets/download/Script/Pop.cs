using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour {

	public GameObject canvasObject;
	public GameObject picture;
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			GameObject prefab = (GameObject)Instantiate (picture);
			prefab.transform.SetParent (canvasObject.transform, false);
			Debug.Log ("Attack");
		}
	}

}
