using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
	public AudioClip se;
	float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 12.0f) {
			GetComponent<AudioSource> ().PlayOneShot (se);
			Destroy (this);
		}
	}
}
