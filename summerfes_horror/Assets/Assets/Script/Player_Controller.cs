using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	Rigidbody m_Rigidbody;
	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
		}

		// WASDで移動する
		float x = 0.0f;
		float z = 0.0f;

		if (Input.GetKey(KeyCode.D))
		{
			x += 2.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			x -= 2.0f;
		}
		if (Input.GetKey(KeyCode.W))
		{
			z += 2.0f;
		}
		if (Input.GetKey(KeyCode.S))
		{
			z -= 2.0f;
		}

		m_Rigidbody.velocity = z * transform.forward + x * transform.right;

	}
}
