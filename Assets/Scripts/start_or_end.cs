﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_or_end : MonoBehaviour {

	public GameObject ob;
	public bool o;
	public void start_withoutDOF(){
		o = false;
		ob.GetComponent<dont_destroy> ().doftrue = o;
		SceneManager.LoadScene ("Brief", LoadSceneMode.Single);

	}

	public void start_withDOF(){
		o = true;
		o = ob.GetComponent<dont_destroy> ().doftrue = o;
		SceneManager.LoadScene ("Brief", LoadSceneMode.Single);

	}


}
