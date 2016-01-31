using UnityEngine;
using System.Collections.Generic;

public class MakeNeighbors : MonoBehaviour {

	public Dictionary<string, string> neighbors;

	void Start () {
		neighbors = new Dictionary<string, string>();
		print ("name = " + gameObject.name);
		switch (gameObject.name) {
		case "A":
			print ("Adding to dict");
			neighbors.Add ("right", "B");
			break;
		case "B":
			neighbors.Add ("left", "A");
			neighbors.Add ("right", "D");
			neighbors.Add ("down", "I");
			break;
		case "C":
			neighbors.Add ("down", "B");
			break;
		case "D":
			neighbors.Add ("up", "E");
			neighbors.Add ("right", "B");
			break;
		case "E":
			neighbors.Add ("left", "F");
			neighbors.Add ("right", "D");
			break;
		case "F":
			neighbors.Add ("left", "E");
			neighbors.Add ("down", "G");
			break;
		case "G":
			neighbors.Add ("left", "I");
			neighbors.Add ("down", "F");
			break;
		case "H":
			neighbors.Add ("down", "G");
			break;
		case "I":
			neighbors.Add ("left", "G");
			neighbors.Add ("right", "J");
			neighbors.Add ("down", "B");
			break;
		case "J":
			neighbors.Add ("up", "I");
			neighbors.Add ("left", "K");
			break;
		case "K":
			neighbors.Add ("right", "L");
			neighbors.Add ("down", "J");
			break;
		case "L":
			neighbors.Add ("left", "K");
			break;
		}
	}

	void respondToButton (string button)
	{
		GetComponentInParent<GoToPoint> ().MoveCam (button);
	}




}
