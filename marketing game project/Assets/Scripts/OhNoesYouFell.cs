using UnityEngine;
using System.Collections;

public class OhNoesYouFell : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "player") {
			Application.LoadLevel ("GameOver");
		}
	}
}