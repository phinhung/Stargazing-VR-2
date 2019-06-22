using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.VR;

public class dont_destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject ob;
	public GameObject arcd;
	public bool doftrue;
	GameObject cam;
	GameObject player;
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (ob);
		if (GameObject.Find ("ARCore Device") != null) {
			arcd = GameObject.Find ("ARCore Device");

			if (doftrue == true){
				arcd.GetComponent<ARCoreSession> ().enabled = true;
			} else if (doftrue == false){
				cam = GameObject.Find ("Main Camera");
				player = GameObject.Find ("Player");
				cam.transform.parent = player.transform ;
				arcd.transform.DetachChildren ();
				Destroy(arcd);

			}
		}
	}
}
