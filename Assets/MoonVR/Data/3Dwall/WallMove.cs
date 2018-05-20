using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour {
	bool gameStart = false;

	public float speed = 4f;
	bool jump;
	int distance = 5;
	// Use this for initialization
	void Start () {
		jump = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameStart){
			
		}
		transform.position -= new Vector3 (0, 0, speed * Time.deltaTime);
		if (!jump){
		}

		
	}
}
