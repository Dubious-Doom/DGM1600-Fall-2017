﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//Specify a variable for the 
	private Rigidbody2D rigid;
	private Transform transform;
	public float speed;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;


	// Use this for initialization
	void Start () {
		rigid = this.GetComponent<Rigidbody2D> ();
		transform = this.GetComponent<Transform> ();
	}

	public void OnCollisionEnter2D (Collision2D collider){
		print ("Ship Collision");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			//shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shot.AddForce(shotPos.forward * shotForce);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			rigid.velocity = new Vector2 (0, speed);
			transform.localEulerAngles = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			rigid.velocity = new Vector2 (0, -speed);
			transform.localEulerAngles = new Vector3 (0, 0, 180);
				}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rigid.velocity = new Vector2 (speed, 0);
			transform.localEulerAngles = new Vector3 (0, 0, -90);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity = new Vector2 (-speed, 0);
			transform.localEulerAngles = new Vector3 (0, 0, 90);
		}

		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.RightArrow)) {
			rigid.velocity = new Vector2 (speed, speed);
			transform.localEulerAngles = new Vector3 (0, 0, -45);
		}

		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.RightArrow)) {
			rigid.velocity = new Vector2 (speed, -speed);
			transform.localEulerAngles = new Vector3 (0, 0, -135);
		}

		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity = new Vector2 (-speed, -speed);
			transform.localEulerAngles = new Vector3 (0, 0, 135);
		}

		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity = new Vector2 (-speed, speed);
			transform.localEulerAngles = new Vector3 (0, 0, 45);
		}
	}
}
