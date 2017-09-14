using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {

	public float force = 20.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ApplyForce() {
		GetComponent<Rigidbody> ().AddForce (transform.forward * force);
	}
}
