using UnityEngine;
using System.Collections.Generic;

public class GoToPoint : MonoBehaviour {

	private Dictionary <string, Transform> camPoints = new Dictionary<string, Transform>();

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform)
		{
			camPoints.Add (child.gameObject.name, child);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoveCam (string camPoint)
	{
		GetComponentInChildren<Camera> ().transform.position = camPoints [camPoint].position;
		GetComponentInChildren<Camera> ().transform.rotation = camPoints [camPoint].rotation;
	}
}
