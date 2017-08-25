using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stop : MonoBehaviour {

	public GameObject target;
	public GameObject monster;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			StartCoroutine ("Stop");
			Debug.Log("Attack");
		}
		}

	IEnumerator Stop(){
		Time.timeScale = 0.001f;
		yield return new WaitForSeconds (0.004f);
		Time.timeScale = 1;
		Instantiate (monster);
		Destroy (this);
		yield break;
	}

}
