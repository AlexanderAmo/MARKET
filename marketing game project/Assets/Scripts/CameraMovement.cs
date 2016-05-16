using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour {
	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;
	public float jumpCount = 0;
	
	public float walkSpeed = 100;
	
	
	private Rigidbody2D body2d;
	private InputState inputState;
	private Animator animator;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (inputState.standing) {
			if (inputState.leftArrow) {
				body2d.velocity = new Vector2 (walkSpeed * -1 , 0);
			
				body2d.velocity = new Vector2 (walkSpeed * -1 , 0);

			}
			if (inputState.rightArrow) {
				body2d.velocity = new Vector2 (walkSpeed , 0);
			
				body2d.velocity = new Vector2 (walkSpeed , 0);

			
			}
		}
	}
}