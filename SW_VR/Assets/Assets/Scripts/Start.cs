using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {
	void OnGUI(){
		if (GUI.Button (new Rect (0, 0, 200, 200), "Quit")) {
			// get to activity
			var androidJC = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			var jo = androidJC.GetStatic<AndroidJavaObject>("currentActivity");

			//access the class for Android
			var jc = new AndroidJavaClass("com.example.fboomplug.StartActivity");
			// paging Android activity paging android activity
			jc.CallStatic("Call" , jo);
		}
	}
}
