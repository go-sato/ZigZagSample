using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.right * Time.deltaTime * -1.0f * speed, Space.World);
	}
		
}
