using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAMEOVER : MonoBehaviour {

	Text myText;
	float timer;
	// Use this for initialization
	void Start () {
		myText = GetComponentInChildren<Text> ();
		timer = 0;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 1.0f) {
			myText.text = "GAME OVER";
		}
	}
}
