using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour {
    public AudioClip se1;
    public AudioClip se2;
    public AudioClip se3;
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
            myText.text = "もうこんな時間か...早く家に帰らないとな";
        }
        if (timer > 4.0f) {
			myText.text = "高速道路を使ったら、数時間で着くか";
		}
        if (timer > 8.0f) {
			myText.text = "ん...この周辺で濃霧か...";
		}
		if (timer > 10.0f) {
			myText.text = "急にっ！？くそっ！！";
		}
        if (timer > 12.0f) {
            myText.text = "";
        }
        if (timer > 18.0f) {
            myText.text = "...うぅ...一体ここは?...携帯もつながらない...";
        }
        if (timer > 21.0f)
        {
            myText.text = "村の奥に光が...誰かいるかもしれない...!";
        }
        if (timer > 25.0f) {
			SceneManager.LoadScene ("terrain");
		}
	}
}
