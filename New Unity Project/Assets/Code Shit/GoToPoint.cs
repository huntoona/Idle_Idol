using UnityEngine;
using System.Collections.Generic;

public class GoToPoint : MonoBehaviour {

	private Dictionary <string, Transform> camPoints = new Dictionary<string, Transform>();
	public GameObject loc;

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform)
		{
			camPoints.Add (child.gameObject.name, child);
		}
		GetComponentInChildren<Camera> ().transform.position = loc.transform.position;
		GetComponentInChildren<Camera> ().transform.rotation = loc.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoveCam (string camPoint)
	{
		string esd = loc.GetComponent<MakeNeighbors> ().neighbors [camPoint];
		print (camPoint);
		GetComponentInChildren<Camera> ().transform.position = camPoints [esd].position;
		GetComponentInChildren<Camera> ().transform.rotation = camPoints [esd].rotation;
		foreach (Transform child in transform)
		{
			if (esd == child.gameObject.name) {
				loc = child.gameObject;
			}
		}

	}
}
