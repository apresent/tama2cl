﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityMan : MonoBehaviour {
	const float Gravity = 9.81f;

	public float gravityscale = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vector = new Vector3 ();

		if(Application.isEditor)
		{
			vector.x = Input.GetAxis ("Horizontal");
			vector.z = Input.GetAxis ("Vertical");

			if(Input.GetKey("z"))
			{
				vector.y = 1.0f;
			}else{
				vector.y = -1.0f;
			}
		}else{
			vector.x = Input.acceleration.x;
			vector.y = Input.acceleration.z;
			vector.z = Input.acceleration.y;
		}
		Physics.gravity = Gravity * vector.normalized * gravityscale;
	}
}
