using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
	public AudioClip se;
    public float target_time;
	float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > target_time) {
			GetComponent<AudioSource> ().PlayOneShot (se);
			Destroy (this);
		}
	}
}
