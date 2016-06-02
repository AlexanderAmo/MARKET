using UnityEngine;
using System.Collections;

public class DestroyFireball : MonoBehaviour {

	float Timer = .5f;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "enemy") {
			Destroy (this.gameObject);
		}
	}

	void Update(){
		Timer -= Time.deltaTime;
		if (Timer < 0) {
			Destroy (this.gameObject);
		}
	}
}
