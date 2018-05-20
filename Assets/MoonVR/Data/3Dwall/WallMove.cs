using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour {
	bool gameStart = false;

	public float speed = 1f;
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
		 transform.position = transform.position - Camera.main.transform.forward * distance * Time.deltaTime* 100;
		if (!jump){
		}

		
	}
}
