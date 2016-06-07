using UnityEngine;
using System.Collections;

public class expandThatWall : MonoBehaviour {

	public float XX;
	public float YY;

	void Start () {
		transform.localScale = new Vector3 (XX, YY, 1);
		
		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (XX, YY, 1);
	}
	
}

	



