using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
		Application.LoadLevel ("lvl2");
	}
}
