using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject booze;
	private int score = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("createObstacle", Random.Range(1f, 3f), Random.Range(1f, 3f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createObstacle() {
		Instantiate (booze);
		score++;
		print(score);
		if(score > 5) {
			CancelInvoke();
			InvokeRepeating("createObstacle", Random.Range(1f, 8f), Random.Range(1f, 8f));
		}
		else {
			CancelInvoke();
			InvokeRepeating("createObstacle", Random.Range(1f, 3f), Random.Range(1f, 3f));
		}
	}
}
