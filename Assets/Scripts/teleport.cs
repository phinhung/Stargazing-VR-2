﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleport : MonoBehaviour {
    private AndroidJavaObject javaClass;
    public GameObject myText;
 
    // Use this for initialization
    void Start () {
        javaClass = new AndroidJavaObject("com.example.vrlibrary.Keys");
    }

	public GameObject play;
	Vector3 newpos;

	public GameObject pointer;
	public Vector3 wpos;

	public void getpospointer(){
		wpos = pointer.GetComponent<GvrReticlePointer> ().CurrentRaycastResult.worldPosition;
		Debug.Log (wpos);
	}
 
 
    public void laufen(string ok)
    {
        if (ok == "1") {
            getpospointer();
            newpos.x = wpos.x;
            newpos.z = wpos.z;
            newpos.y = 1.66f;
            play.transform.position = newpos;
            myText.GetComponent<Text>().text = "laufen";
        }
    }
}
