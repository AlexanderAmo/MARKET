using UnityEngine;
using System.Collections;

public class lvl3to : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "player") {
			Application.LoadLevel ("lvl3");
		}			
	}
}
