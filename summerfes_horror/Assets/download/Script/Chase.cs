using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chase : MonoBehaviour {

	public GameObject obj ;
    private Transform target;
	public float speed = 0.1f;
	private Vector3 vec;

	// Use this for initialization
	void Start () {
         obj = GameObject.Find("Main Camera");
        target = obj.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), 0.3f);
		transform.position += transform.forward * speed;
		}
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			SceneManager.LoadScene ("GameOver");
		
		}
	
	}
}
