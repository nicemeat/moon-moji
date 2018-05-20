using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerscript3 : MonoBehaviour {
	GameObject statetext;
	GameObject wall2;
	// Use this for initialization
	void Start () {
		statetext = GameObject.Find ("statetext");
		wall2 = GameObject.Find ("pose1");
		//statetext.GetComponent<TextMesh> ().text = "ああああああ";
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 4 && Time.timeSinceLevelLoad <= 7) {
			statetext.GetComponent<TextMesh> ().text = "スタート!";
		} else {
			statetext.GetComponent<TextMesh> ().text = "";
		}

		if (Time.timeSinceLevelLoad >= 7 && Time.timeSinceLevelLoad <= 8) {
			wall2.GetComponent<WallMove3> ().isStart = true;
		}


	}
}
