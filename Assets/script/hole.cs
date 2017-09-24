using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour {
	bool fallin;
	public string activeTag;

	public bool isFallIn(){
		return fallin;
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == activeTag){
			fallin = true;
		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == activeTag){
			fallin = false;
		}
	}

	void OnTriggerStay(Collider other){
		Rigidbody rb = other.gameObject.GetComponent<Rigidbody> ();
		Vector3 direction = transform.position - other.gameObject.transform.position;
		direction.Normalize ();

		if(other.gameObject.tag == activeTag){
			rb.velocity *= 0.9f;
			rb.AddForce (direction * rb.mass * 20.0f);
		}else{
			rb.AddForce (-direction * rb.mass * 80.0f);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
