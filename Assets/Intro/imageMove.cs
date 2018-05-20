using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageMove : MonoBehaviour {
	float scaleRate = 0.03f;
	int distance = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position - Camera.main.transform.forward * distance * Time.deltaTime* 50;
		ApplyScaleRate();
	}

	void ApplyScaleRate() {
		transform.localScale += Vector3.one * scaleRate;
	}
	
}
