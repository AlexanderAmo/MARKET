using UnityEngine;
using System.Collections;

public class animatorController : MonoBehaviour {

	public static animatorController instance;

	Transform myTrans;
	Animator myAnim;
	Vector3 artScaleCache;


	// Use this for initialization
	void Start () {
		instance = this;
		myTrans = this.transform;
		myAnim = this.gameObject.GetComponent<Animator>();

		artScaleCache = myTrans.localScale;
	}


	void FlipArt(float currentSpeed){
		if ((currentSpeed < 0 && artScaleCache.x == 1) ||
			(currentSpeed > 0 && artScaleCache.x == -1)) {
			artScaleCache.x*= -1;
			myTrans.localScale = artScaleCache;
		}
	}

	public void UpdateSpeed(float currentSpeed){
		myAnim.SetFloat ("Speed", currentSpeed);
		FlipArt (currentSpeed);
	}

	public void UpdateIsGrounded(bool isGrounded) {
		myAnim.SetBool ("IsGrounded", isGrounded);
	}
}
