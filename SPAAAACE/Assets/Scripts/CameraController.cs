﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform objectToFollow;
	public float zOffset = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//
		Vector3 myPos = objectToFollow.position;
		myPos.z = zOffset;
		gameObject.transform.position = myPos;
	}
}
