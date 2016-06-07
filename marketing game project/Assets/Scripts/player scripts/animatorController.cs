using UnityEngine;
using System.Collections;

public class animatorController : MonoBehaviour {

	public static animatorController instance;

	Transform myTrans;
	Animator myAnim;
	Vector3 artScaleCache;
	string Dir = "Right";

	void Awake(){
		myAnim = this.gameObject.GetComponent<Animator>();

	}


	// Use this for initialization
	void Start () {
		instance = this;
		myTrans = this.transform;
		myAnim = this.gameObject.GetComponent<Animator>();

		artScaleCache = myTrans.localScale;
	}

	public string getDir(){
		return Dir;
	}
	void FlipArt(float currentSpeed){


		if ((currentSpeed < 0 && artScaleCache.x == 1) ||
			(currentSpeed > 0 && artScaleCache.x == -1)) {
			artScaleCache.x*= -1;
			myTrans.localScale = artScaleCache;
		}
		if (artScaleCache.x == 1) {
			Dir = "Right";
		}
		if (artScaleCache.x == -1) {
			Dir = "Left";
		}
	}
	public void UpdateIsGrounded(bool isGrounded) {
		myAnim.SetBool ("IsGrounded", isGrounded);
	}

	public void UpdateSpeed(float currentSpeed){
		myAnim.SetFloat ("Speed", currentSpeed);
		FlipArt (currentSpeed);

	}

}
