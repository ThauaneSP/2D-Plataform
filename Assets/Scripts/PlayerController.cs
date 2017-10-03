using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float HorizontalSpeed = 5f;

	public float jumpspeed = 600f;

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

		if (Input.GetButtonDown("Jump")) {
			Jump();
		}
	}


	void MoveHorizontal(float speed) {
		rb.velocity= new Vector2(speed, rb.velocity.y);
	}

	void StopMovingHorizontal () {
		rb.velocity = new Vector2(0f , rb.velocity.y);
	}

	void Jump () {
		rb.AddForce(new Vector2(0f , jumpspeed));
	}
}
