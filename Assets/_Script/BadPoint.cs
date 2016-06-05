using UnityEngine;
using System.Collections;

public class BadPoint : MonoBehaviour {

	ScoreManager scoreManager;
	PlaySound headSound;
	PlaySound tailSound;
	PlayerManager playerManager;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.Find ("Score").GetComponent<ScoreManager> ();

		headSound = GameObject.Find ("HeadSound").GetComponent<PlaySound> ();
		tailSound = GameObject.Find ("TailSound").GetComponent<PlaySound> ();

		playerManager = GameObject.Find ("Player").GetComponent<PlayerManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("Player")) {
			//headSound.Play ();
			//ロボにダメージ
			playerManager.damage();
		}

		if (other.gameObject.CompareTag ("Trail")) {
			//tailSound.Play ();
			tailSound.Play ();
			scoreManager.AddScore ();
		}

		Destroy (gameObject);
	}
}
