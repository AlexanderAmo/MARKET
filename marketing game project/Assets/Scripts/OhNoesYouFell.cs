using UnityEngine;
using System.Collections;

public class OhNoesYouFell : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D other){
		Application.LoadLevel ("GameOver");
	}
}