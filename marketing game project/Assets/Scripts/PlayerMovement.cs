using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed = 10f, jumpVelocity = 10f;
	public LayerMask playermask;
	Transform myTrans, TagGround;
	Rigidbody2D myRigid;

	public bool isGrounded = false;

	// Use this for initialization
	void Start () {
		myRigid = this.GetComponent<Rigidbody2D> ();
		myTrans = this.transform;
		TagGround = GameObject.Find (this.name + "/tag_ground").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		isGrounded = Physics2D.Linecast (myTrans.position, TagGround.position, playermask);


		move (Input.GetAxisRaw("Horizontal"));
		if (Input.GetButtonDown ("Jump")) {
			jump();
		}
	}

	public void move(float HorizontalInput){
		Vector2 moveVel = myRigid.velocity;
		moveVel.x = HorizontalInput * speed;
		myRigid.velocity = moveVel;
	}
	public void jump(){
		if (isGrounded) {
			myRigid.velocity += jumpVelocity * Vector2.up;
		}
	}

}
