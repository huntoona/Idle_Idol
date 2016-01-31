using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MasterInventory : MonoBehaviour {

	ArrayList inv;

	Image[] imageComponents;

	public NamedSprite[] sprites;

	public struct NamedSprite {
		public string name;
		public Sprite image;
		public NamedSprite(string setName, UnityEngine.Sprite setSprite) {
			name = setName;
			image = setSprite;
		}
	}

	//public OpenCloseObjectMenu 

	// Use this for initialization
	void Start () {
		inv = new ArrayList ();
		sprites [0] = new NamedSprite ("Stapler", Resources.Load<Sprite>("Sprites/Stapler"));
		sprites [1] = new NamedSprite ("Burrito", Resources.Load<Sprite>("Sprites/Burrito"));
		sprites [2] = new NamedSprite ("Calculator", Resources.Load<Sprite>("Sprites/Calculaor"));
		sprites [3] = new NamedSprite ("Coffee Bean", Resources.Load<Sprite>("Sprites/Coffee_Bean"));
		sprites [4] = new NamedSprite ("Coffee Beans", Resources.Load<Sprite>("Sprites/Coffee_Beans"));
		sprites [5] = new NamedSprite ("Drive", Resources.Load<Sprite>("Sprites/Drive"));
		sprites [6] = new NamedSprite ("Ink_Wells", Resources.Load<Sprite>("Sprites/Ink_Wells"));
		sprites [7] = new NamedSprite ("Light Bulb", Resources.Load<Sprite>("Sprites/Light_Bulb"));
		sprites [8] = new NamedSprite ("Markers", Resources.Load<Sprite>("Sprites/Markers"));
		sprites [9] = new NamedSprite ("Milk", Resources.Load<Sprite>("Sprites/Milk"));
		sprites [10] = new NamedSprite ("Paper", Resources.Load<Sprite>("Sprites/Paper"));
		sprites [11] = new NamedSprite ("Scissors", Resources.Load<Sprite>("Sprites/Scissors"));
		sprites [12] = new NamedSprite ("Tiki", Resources.Load<Sprite>("Sprites/Tiki"));
		sprites [13] = new NamedSprite ("Water Pitcher", Resources.Load<Sprite>("Sprites/Water_Pitcher"));
	}

	// Update is called once per frame
	void Update () {
		int invIndex = 0;
		imageComponents = this.gameObject.GetComponentsInChildren<Image>();
		foreach(string obj in inv) {
			imageComponents[invIndex].sprite = this.getImageByName(obj);
			invIndex++;
		}
	}

	public void catchObjToInv (string toAdd) {
		inv.Add (toAdd);
	}

	public Sprite getImageByName(string name) {
		foreach(NamedSprite sprite in sprites) {
			if (sprite.name == name) {
				return sprite.image;
			}
		}
		print ("You done fucked");
		return null;
	}
}
