﻿using UnityEngine;
using System.Collections;

public class Collect: MonoBehaviour {

	public string materialName;
	private bool registered = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Player") && !registered) {
			registered = true;
			GameObject.Find("Inventory").GetComponent<Inventory>().addItem(materialName);
			GameObject.Destroy(this.gameObject);
		}
	}
	void OnTriggerStay2D(Collider2D other) {
		if (other.CompareTag ("Player") && !registered) {
			registered = true;
			GameObject.Find("Inventory").GetComponent<Inventory>().addItem(materialName);
			GameObject.Destroy(this.gameObject);
		}
	}
}
