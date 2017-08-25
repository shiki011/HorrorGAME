using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off : MonoBehaviour {
	public Light mylight;

	void Start(){
		mylight = GetComponent<Light> ();
		mylight.enabled = true;
	
	}
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "block") {

			StartCoroutine ("OnOff");
			Debug.Log ("Attack");
		}
	
	}
	IEnumerator OnOff (){
		mylight.enabled = false;
		yield return new WaitForSeconds (0.3f);
		mylight.enabled = true;
		yield return new WaitForSeconds (0.3f);
		mylight.enabled = false;
		yield return new WaitForSeconds (0.3f);
		mylight.enabled = true;
		yield return new WaitForSeconds (0.3f);
		mylight.enabled = false;
		yield return new WaitForSeconds (0.3f);
		mylight.enabled = true;
		yield return new WaitForSeconds (0.3f);
		mylight.enabled = false;
		yield return new WaitForSeconds (0.1f);
		mylight.enabled = true;
		yield return new WaitForSeconds (0.1f);
		mylight.enabled = false;
		yield return new WaitForSeconds (0.1f);
		mylight.enabled = true;
		yield return new WaitForSeconds (0.1f);
		mylight.enabled = false;
		yield return new WaitForSeconds (0.1f);
		mylight.enabled = true;
		yield return new WaitForSeconds (0.1f);
		mylight.enabled = false;
		yield return new WaitForSeconds (5.0f);
		mylight.enabled = true;

	}
}


