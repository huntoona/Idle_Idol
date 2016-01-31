using UnityEngine;
using System.Collections;

public class FireClickEventScript : MonoBehaviour {

	public string dir;
	public Camera playerCam;
	public GoToPoint gtp;

	//private int framesToCanPress;

	// Use this for initialization
	void Start () {
		//framesToCanPress = 0;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//print (framesToCanPress);
		//if (framesToCanPress <= 0) {
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				print ("Got here");
				gtp.MoveCam ("down");
				//framesToCanPress = 60;
			} else if (Input.GetKeyUp (KeyCode.UpArrow)) {
				print ("Got here");
				gtp.MoveCam ("up");
			//	framesToCanPress = 60;
			} else if (Input.GetKeyUp (KeyCode.RightArrow)) {
				print ("Got here");
				gtp.MoveCam ("right");
				//framesToCanPress = 60;
			} else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				print ("Got here");
				gtp.MoveCam ("left");
				//framesToCanPress = 60;
			}
		//} else {
		//	framesToCanPress--;
		//}
		/*
		if(Input.GetMouseButtonDown(0)) {
			Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				print ("Got here");
				gtp.MoveCam (dir);
			}
		}
		*/
	}
}
