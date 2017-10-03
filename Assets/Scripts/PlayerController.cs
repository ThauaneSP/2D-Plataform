﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float HorizontalSpeed = 10f;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		float horizontalInput = Input.GetAxisRaw("Horizontal"); // -1? esquerda , 1: direita
		float HorizontalPlayerSpeed = HorizontalSpeed * horizontalInput;
		if (HorizontalSpeed != 0) {
			MoveHorizontal(HorizontalPlayerSpeed);
		}
		else {
			StopMovingHorizontal();
		}
	}

	void MoveHorizontal(float speed) {
		rb.velocity= new Vector2(speed, rb.velocity.y);
	}

	void StopMovingHorizontal () {
		rb.velocity = new Vector2(0f , rb.velocity.y);
	}
}
