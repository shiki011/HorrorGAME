using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Run : MonoBehaviour {

	float time = 0.0f;
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (time >= 1.5f) {

			transform.Translate (0, 0, 0.3f);
		}

	}
}
