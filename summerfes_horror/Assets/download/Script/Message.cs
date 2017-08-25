using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour {

	Text myText;
	float timer;
	// Use this for initialization
	void Start () {
		myText = GetComponentInChildren<Text> ();
		myText.text = "やった...灯りのついた家だ...";
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 5.0f) {
			myText.text = "助かった...これで助かったんだ...";
		}
		if (timer > 10.0f) {
			myText.text = "おーい、誰かいませんかー...";
		}
		if (timer > 13.0f) {
			myText.text = "";
		}
		if (timer > 16.0f) {
			myText.text = "GAME CLEAR";
		}
	}
}
