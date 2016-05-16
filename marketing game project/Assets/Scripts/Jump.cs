using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Jump : MonoBehaviour {

	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;
	public float jumpCount = 1;

	public float walkSpeed = 100;


	private Rigidbody2D body2d;
	private InputState inputState;
	private Animator animator;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		var goingleft = false;
		var goingright = false;

		if (inputState.standing) {
			if (inputState.actionButton) {
				body2d.velocity = new Vector2 (forwardSpeed , jumpSpeed);
				body2d.velocity = new Vector2 (forwardSpeed , jumpSpeed);
			}
			if (inputState.actionButton2) {
				body2d.velocity = new Vector2 (forwardSpeed , jumpSpeed * 2f);
				body2d.velocity = new Vector2 (forwardSpeed , jumpSpeed * 2f);
			}

			if (inputState.leftArrow) {
				body2d.velocity = new Vector2 (walkSpeed * -1 , 0);
				body2d.velocity = new Vector2 (walkSpeed * -1 , 0);
				goingleft = true;
				animator.SetBool ("GoingLeft", goingleft);
			}
		animator.SetBool ("GoingLeft", goingleft);
			if (inputState.rightArrow) {
				body2d.velocity = new Vector2 (walkSpeed , 0);

				body2d.velocity = new Vector2 (walkSpeed , 0);
				goingright = true;
				animator.SetBool ("GoingRight", goingright);
		}
		animator.SetBool ("GoingRight", goingright);
		}
	}
}