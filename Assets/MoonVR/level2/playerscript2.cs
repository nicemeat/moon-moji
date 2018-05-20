using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerscript2 : MonoBehaviour {

	GameObject targetText;
	GameObject targetText2;
	GameObject targetText3;
	GameObject angletext;
	GameObject angletexty;
	GameObject angletextz;
	GameObject info;
	//	private GameObject _parent;
	public GameObject mainCamera ;
	GameObject player;
	public float height;
	string text = "";
	Rigidbody rb;
	public bool jumping = false;
	// Use this for initialization
	void Start () {
		//		targetText = GameObject.Find ("debuglog");
		//		targetText2 = GameObject.Find ("savedData");
		//		targetText3 = GameObject.Find ("currentData");
		//		angletext = GameObject.Find ("angle");
		//		angletexty = GameObject.Find ("angley");
		//		angletextz = GameObject.Find ("anglez");
		info = GameObject.Find("infotext");
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");

		player = GameObject.FindGameObjectWithTag ("Player");
		rb = player.GetComponent<Rigidbody> ();
		height = mainCamera.transform.position.y;
	}

	// Update is called once per frame
	void Update () {

		if (mainCamera.transform.position.y - height >= 0.13 && jumping != true) {
			text += "\njump!";
			jumping = true;
			rb.AddForce (0, 240, 0);
		} else if (mainCamera.transform.position.y - height < 0.13) {
			jumping = false;
		}


		info.GetComponent<TextMesh> ().text = "default = "+height+ "  current = "+mainCamera.transform.position.y;

		if (GvrControllerInput.ClickButtonDown)
		{
			height = mainCamera.transform.position.y;
		}

		//		targetText.GetComponent<TextMesh> ().text = text;
		//		targetText2.GetComponent<TextMesh> ().text = height+"";
		//		targetText3.GetComponent<TextMesh> ().text = mainCamera.transform.position.y+"";
		//		angletext.GetComponent<TextMesh> ().text = "x="+GvrControllerInput.Orientation.eulerAngles.x + "";
		//		angletexty.GetComponent<TextMesh> ().text = "x="+GvrControllerInput.Orientation.eulerAngles.y + "";
		//		angletextz.GetComponent<TextMesh> ().text = "x="+GvrControllerInput.Orientation.eulerAngles.z + "";
		//targetText.GetComponent<TextMesh> ().text = "x="+GvrControllerInput.Gyro.x+"\ny="+GvrControllerInput.Gyro.y+"\nz="+GvrControllerInput.Gyro.z;
	}
}
