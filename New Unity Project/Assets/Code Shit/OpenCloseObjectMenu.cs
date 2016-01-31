using UnityEngine;
using System.Collections;

public class OpenCloseObjectMenu : MonoBehaviour {

	public GameObject menuItemTop;
	public Camera playerCamera;

	// Use this for initialization
	void Start () {
		print ("HelloInit");
	}

	// Update is called once per frame

	void Update () {
		Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Input.GetMouseButtonDown(0)) {
			if (Physics.Raycast(ray, out hit)) {
				menuItemTop.SetActive (!menuItemTop.activeInHierarchy);
			}
		}
		Component halo = this.GetComponent ("Halo");
		if (Physics.Raycast (ray, out hit)) {
			halo.GetType ().GetProperty ("enabled").SetValue (halo, true, null);
		} else {
			halo.GetType ().GetProperty ("enabled").SetValue (halo, false, null);
		}
	}

	public void disable() {
		this.gameObject.SetActive (false);
	}

	public void renderSprite() {

	}
}