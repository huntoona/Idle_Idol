using UnityEngine;
using System.Collections;

public class ObjPickUp : MonoBehaviour {

	public MasterInventory addTo;
	public OpenCloseObjectMenu item;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void fireObjToInv () {
		print ("Hello");
		item.disable ();
		addTo.catchObjToInv(this.gameObject);
	}
}
