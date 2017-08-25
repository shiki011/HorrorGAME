using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Generate : MonoBehaviour {

	public GameObject monster;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			Instantiate (monster);
            Destroy(this);
		
		}
	
	}
}
