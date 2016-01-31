using UnityEngine;
using System.Collections;

public class MasterInventory : MonoBehaviour {

	ArrayList inv;

	// Use this for initialization
	void Start () {
		inv = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void catchObjToInv (GameObject toConv) {
		inv.Add (toConv);
	}
}
