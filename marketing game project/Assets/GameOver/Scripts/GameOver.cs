using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle Random1;
	
	public bool showGUIOutline = true;
	public float guiPlacementY1;
	public float guiPlacementY2;
	public float guiPlacementX1;
	public float guiPlacementX2;
	
	void OnGUI(){
		//Display Our Background Texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		
		if (showGUIOutline) {
			//displays our buttons (With GUI Outline)
			if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Continue?")) {
				print ("Clicked Continue");
				Application.LoadLevel("Lvl1");
			}
		} 
		else {
			
			
			//displays our buttons (Without GUI Outline)
			if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "", Random1)) {
				print ("Clicked Play Game");
			}
			
			if (GUI.Button (new Rect (Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "", Random1)) {
				print ("Clicked Options");
			}
		}
	}
}