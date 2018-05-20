using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassDetect : MonoBehaviour {
	public GvrArmModel arm;
	Quaternion armRotate;

	// Use this for initialization
	void Start () {
		armRotate = arm.ControllerRotationFromHead;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
	}
}
