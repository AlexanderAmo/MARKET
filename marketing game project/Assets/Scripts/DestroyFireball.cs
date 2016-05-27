using UnityEngine;
using System.Collections;

public class DestroyFireball : MonoBehaviour {

	float Timer = .5f;
	void Update(){
		Timer -= Time.deltaTime;
		if (Timer < 0) {
			Destroy (this.gameObject);
		}
	}
}
