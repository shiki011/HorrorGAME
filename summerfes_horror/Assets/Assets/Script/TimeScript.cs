using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	GameObject timer;
	float time = 300.0f;

	void Start(){
		this.timer = GameObject.Find("TimeGauge");
	}

	void Update(){
		this.time -= Time.deltaTime;
		this.timer.GetComponent<Image> ().fillAmount = time / 300.0f;
		if (this.time < 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}
}

