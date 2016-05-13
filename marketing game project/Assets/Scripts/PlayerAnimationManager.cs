using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
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
	
		var goingright = false;
		var goingleft = false;

		if(inputState.rightArrow = true){
			animator.SetBool ("GoingRight", goingright);
		}
		if (inputState.leftArrow = true) {
			animator.SetBool ("GoingLeft", goingleft);
		}
	}
}
