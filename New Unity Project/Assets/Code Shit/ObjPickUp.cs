using UnityEngine;
using System.Collections;

public class ObjPickUp : MonoBehaviour {

	public MasterInventory addTo;
	public OpenCloseObjectMenu item;
	public string itemName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void fireObjToInv () {
		print ("Hello");
		addTo.catchObjToInv(itemName);
		item.disable ();
	}
}
