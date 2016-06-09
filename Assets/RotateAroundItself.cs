﻿using UnityEngine;
using System.Collections;

public class RotateAroundItself : MonoBehaviour {

	public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position,Vector3.up , speed);
	}
}
