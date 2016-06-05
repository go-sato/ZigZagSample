using UnityEngine;
using System.Collections;

public class Sidebar : MonoBehaviour {

	PlayerManager playerManager;

	// Use this for initialization
	void Start () {
		playerManager = GameObject.Find("Player").GetComponent<PlayerManager> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			playerManager.ChangeDirection ();
		}

	}
}
