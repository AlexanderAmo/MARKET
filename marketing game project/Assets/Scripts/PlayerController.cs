using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed = 10f, jumpVelocity = 10f;
	public LayerMask playermask;
	Transform myTrans, TagGround;
	Rigidbody2D myRigid;
	public bool isGrounded = false;
	animatorController myAnim;
	float hInput = 0;

	Rigidbody2D Ball;
	public Transform FirePoint;
	public Rigidbody2D Fireball;
	public float Speed2;
	Animator life;




	// Use this for initialization
	void Start () {
		myAnim = animatorController.instance;
		myRigid = this.GetComponent<Rigidbody2D> ();
		myTrans = this.transform;
		TagGround = GameObject.Find (this.name + "/tag_ground").transform;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		isGrounded = Physics2D.Linecast (myTrans.position, TagGround.position,playermask);
		myAnim.UpdateIsGrounded (isGrounded);

		#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT
		hInput = Input.GetAxisRaw("Horizontal");
		myAnim.UpdateSpeed (hInput);
		if (Input.GetButtonDown ("Jump")) 
			jump();
		if (Input.GetKeyDown(KeyCode.W)){
			FireBallFire();
		}
		#endif
		move (hInput);
	}

	void move(float HorizontalInput){

		Vector2 moveVel = myRigid.velocity;
		moveVel.x = HorizontalInput * speed;
		myRigid.velocity = moveVel;
	}
	public void jump(){
		if (isGrounded) {
			myRigid.velocity += jumpVelocity * Vector2.up;
		}
	}
	public void startMoving(float horizonalInput){
		hInput = horizonalInput;
		myAnim.UpdateSpeed (horizonalInput);
	}

	public void FireBallFire(){
		if (myAnim.getDir().Equals("Right")) {
			Fireball.transform.localScale = new Vector3(-1, 1, 1);
			Speed2 = 50;
			Ball = Instantiate (Fireball, FirePoint.position, FirePoint.rotation) as Rigidbody2D;

		}
		if (myAnim.getDir().Equals("Left")) {
			Fireball.transform.localScale = new Vector3(1, 1, 1);
			Speed2 = -50;
			Ball = Instantiate (Fireball, FirePoint.position, FirePoint.rotation) as Rigidbody2D;


		}
		Ball.velocity = new Vector2 (Speed2, 0);
	}
}
