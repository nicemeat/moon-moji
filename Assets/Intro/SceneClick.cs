using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneClick : MonoBehaviour {

	GameObject press;
	// Use this for initialization
	void Start () {
		press = GameObject.Find("aaaa");
	}
	
	// Update is called once per frame
	void Update () {
		if (GvrControllerInput.ClickButtonDown)
		{
		 SceneManager.LoadScene("Tutorial",LoadSceneMode.Additive);
		press.GetComponent<TextMesh> ().text = "x="+GvrControllerInput.Orientation.eulerAngles.x + "";
		}
		
	}
}
