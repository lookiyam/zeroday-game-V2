﻿using UnityEngine;
using System.Collections;

public class FirewallBarrier : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		private void OnTriggerEnter2D(Collider2D collider){
		Debug.Log("Trigger!");
	}
}
