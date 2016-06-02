using UnityEngine;
using System.Collections;

public class EnemySlayer : MonoBehaviour {
	

	void OnCollisionEnter2D (Collision2D fire){
		if (fire.gameObject.tag == "FireBall") {
			Destroy (this.gameObject);
		}
	}
}