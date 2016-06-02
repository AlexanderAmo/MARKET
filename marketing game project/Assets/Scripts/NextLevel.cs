using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "player") {
			Application.LoadLevel ("lvl2");
		}			
	}
}
