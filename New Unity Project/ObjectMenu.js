#pragma strict

// GameObjects
public var menuItems;
// Camera
public var mainCameraPlayer;

function Start () {
	debug.log ("HelloInit");
	menuItems = this.gameObject.getComponentsFromChildren
}

function Update () {
	if(Input.GetMouseButtonDown(0)) {
		debug.log ("Hello");
		var ray = this.mainCameraPlayer.ScreenPointToRay(Input.mousePosition);
		var hit: RaycastHit;
		if(Physics.Raycast(ray, hit)) {
			foreach(GameObject c in menuItems) {
				if(c.activeInHierarchy) {
					c.SetActive(false);
				} else {
					c.SetActive (true);
				}
			}
		}
	}
}