﻿using UnityEngine;
using System.Collections;

public class SpawnTrail : MonoBehaviour {

	public GameObject spawnObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (spawnObject, transform.position, Quaternion.identity);
	}
}
