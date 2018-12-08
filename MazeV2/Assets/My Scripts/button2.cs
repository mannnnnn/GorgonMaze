﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;
	private Keypad keypad;
	
	// Use this for initialization
	void Start () {
		keypad = Door.GetComponent<Keypad>();
		//var myScript Keypad = GetComponent.<Keypad>();
	}
	
	// Update is called once per frame
	void Update () {
		if (doorIsOpening){
			keypad.key2= true;
			doorIsOpening = false;
		}
	}
	
	void OnCollisionEnter(Collision other){
			doorIsOpening = true;
	}
	//void OnMouseDown(){
	//	doorIsOpening = true;
	//}
}