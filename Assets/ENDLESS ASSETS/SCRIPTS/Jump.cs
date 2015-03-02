using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private int track = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			track = track + 1;
			if(track < 2) {
				rigidbody2D.transform.position = new Vector3(0, rigidbody2D.transform.position.y + 4, -1);
			}
		}
	}
}
