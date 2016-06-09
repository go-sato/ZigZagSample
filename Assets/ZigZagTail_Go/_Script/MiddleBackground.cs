using UnityEngine;
using System.Collections;

public class MiddleBackground : MonoBehaviour {

	public float speed = 5.0f;
	Vector3 pos;
	float changeValue;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		changeValue = Time.deltaTime * speed;
		pos.y -= changeValue;
		transform.position = pos;
	}
}
