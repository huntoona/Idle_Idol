using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MasterInventory : MonoBehaviour {

	Image[] imageComponents;

	public struct InvSprite {
		public string name;
		public bool show;
		public InvSprite(string setName, bool setShow) {
			name = setName;
			show = setShow;
		}
	}

	//public OpenCloseObjectMenu 

	// Use this for initialization
	void Start () {
		imageComponents = GetComponentsInChildren<Image>(true);
	}

	// Update is called once per frame
	//void Update () {
		
	//}

	public void catchObjToInv (string toAdd) {
		setVisibleByName (toAdd);
	}

	public void setVisibleByName(string name) {
		print (imageComponents.Length);
		switch (name) {
		case "Burrito":
			imageComponents [0].gameObject.SetActive (true);
			break;
		case "Calculator":
			imageComponents [1].gameObject.SetActive (true);
			break;
		case "Coffee Bean":
			imageComponents [2].gameObject.SetActive (true);
			break;
		case "Coffee Beans":
			imageComponents [3].gameObject.SetActive (true);
			break;
		case "Drive":
			imageComponents [4].gameObject.SetActive (true);
			break;
		case "Ink Wells":
			imageComponents [5].gameObject.SetActive (true);
			break;
		case "Light Bulb":
			imageComponents [6].gameObject.SetActive (true);
			break;
		case "Markers":
			imageComponents [7].gameObject.SetActive (true);
			break;
		case "Milk":
			imageComponents [8].gameObject.SetActive (true);
			break;
		case "Paper":
			imageComponents [9].gameObject.SetActive (true);
			break;
		case "Scissors":
			imageComponents [10].gameObject.SetActive (true);
			break;
		case "Stapler":
			print ("WE ARE ACTIVATING A STAPLER");
			imageComponents [11].gameObject.SetActive (true);
			break;
		case "Tiki":
			imageComponents [12].gameObject.SetActive (true);
			break;
		case "Water Pitcher":
			imageComponents [13].gameObject.SetActive (true);
			break;
		default:
			print ("You done fucked");
			break;
		}
	}
}
