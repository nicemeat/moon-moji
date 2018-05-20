using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallMove2 : MonoBehaviour {
	bool gameStart = false;

	public float speed = 8f;
	public bool isStart;
	bool jump;
	GameObject player;
	GameObject jumptext;
	int distance = 5;
	// Use this for initialization
	void Start () {
		jump = false;
		isStart = false;
		player = GameObject.FindGameObjectWithTag ("Player");
		jumptext = GameObject.Find ("jumptext");
	}

	// Update is called once per frame
	void Update () {
		if (isStart) {
			transform.position -= new Vector3 (0, 0, speed * Time.deltaTime);
		}
		Debug.Log ((player.transform.position.z - this.transform.position.z) / speed);
		//Debug.Log (this.transform.position.x);

		if ((transform.position.z - player.transform.position.z) / speed < 6 && (transform.position.z - player.transform.position.z) / speed > 2 && !player.GetComponent<playerscript>().jumping) {
			jumptext.GetComponent<TextMesh> ().text = "飛んで！";
		} else {
			jumptext.GetComponent<TextMesh> ().text = "";
		}

		if ((transform.position.z - player.transform.position.z) / speed <= 0) {
			//jumptext.GetComponent<TextMesh> ().text = "グレート! 5秒後に次のレベルに移動します";
			//スコア表示
		}
		if ((transform.position.z - player.transform.position.z) / speed <= -5) {
			SceneManager.LoadScene("Level3");
		}

	}
}
