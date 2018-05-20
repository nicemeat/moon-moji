using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTimer : MonoBehaviour {

float timeRemaining = 5.0f;
private GUIStyle guiStyle = new GUIStyle(); 
    void Update () {
        timeRemaining -= Time.deltaTime;
    }
    
    void OnGUI(){
		guiStyle.fontSize = 50;
        if(timeRemaining > 0){
            GUI.Label(new Rect(100, 100, 200, 100), 
                         "Time Remaining : "+timeRemaining,guiStyle);
        }
        else{
            GUI.Label(new Rect(100, 100, 200, 100), "Start",guiStyle);

        }
    }
}
