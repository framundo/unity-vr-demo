﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		gameObject.GetComponent<Renderer> ().material.color = Color.green;
		foreach (Transform child in transform) {
			child.gameObject.SetActive(true);
		}
	}
}
