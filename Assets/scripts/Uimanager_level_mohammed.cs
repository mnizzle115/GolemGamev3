﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uimanager_level_mohammed : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetString("blue") == "true" && PlayerPrefs.GetString("green") == "true" ){
			Application.LoadLevel("DarkLevel");
		
		}
		
	}
}
