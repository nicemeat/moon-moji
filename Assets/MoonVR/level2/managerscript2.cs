using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerscript2 : MonoBehaviour {
	GameObject statetext;
	GameObject wall1;
	// Use this for initialization
	void Start () {
		statetext = GameObject.Find ("statetext");
		wall1 = GameObject.Find ("pose4");
		//statetext.GetComponent<TextMesh> ().text = "ああああああ";
	}

	// Update is called once per frame
	void Update () {
		if (Time.time >= 4 && Time.time <= 7) {
			statetext.GetComponent<TextMesh> ().text = "スタート!";
		} else {
			statetext.GetComponent<TextMesh> ().text = "";
		}

		if (Time.time >= 7 && Time.time <= 8) {
			wall1.GetComponent<WallMove> ().isStart = true;
		}


	}
}
