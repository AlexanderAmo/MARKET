using UnityEngine;
using System.Collections;

public class PlayerAnimationManager : MonoBehaviour {

	private Animator animator;
	private InputState inputState;

	// Use this for initialization
	void Awake () {
	
		animator = GetComponent<Animator> ();
		inputState = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		var running = false;
		var running2 = false;
		var jumping = false;

		if(inputState.rightArrow = true){
			running = true;
			//animator.SetBool ("Running", running);
		}
		if (inputState.leftArrow = true) {
			running = true;
			//animator.SetBool ("Running", running);
		}
		if(inputState.actionButton = true){
			jumping = true;
			//animator.SetBool ("Jumping", jumping);
		}
		if (inputState.actionButton2 = true) {
			jumping = true;
			//animator.SetBool ("Jumping", jumping);
		}
		//animator.SetBool ("Running", running);
		//animator.SetBool ("Jumping", jumping);


	}
}
