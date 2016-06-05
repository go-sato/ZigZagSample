using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	ScoreManager scoreManager;
	PlaySound headSound;
	PlaySound tailSound;

	ComboManager comboManager;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.Find ("Score").GetComponent<ScoreManager> ();
		comboManager = GameObject.Find ("Combo").GetComponent<ComboManager> ();

		headSound = GameObject.Find ("HeadSound").GetComponent<PlaySound> ();
		tailSound = GameObject.Find ("TailSound").GetComponent<PlaySound> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		//エフェクト発生position
		//Debug.Log (gameObject.transform.position);

		if (other.gameObject.CompareTag ("Player")) {
			comboManager.GetPoint ();
			headSound.Play ();
		}

		if (other.gameObject.CompareTag ("Trail")) {
			tailSound.Play ();
		}
			
		scoreManager.AddScore ();
		Destroy (gameObject);
	}
}
