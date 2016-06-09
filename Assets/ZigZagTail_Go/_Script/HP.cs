using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {

	HPManager hpManager;
	PlaySound headSound;
	PlaySound tailSound;

	ComboManager comboManager;

	// Use this for initialization
	void Start () {
		hpManager = GameObject.Find ("HP").GetComponent<HPManager> ();

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
			hpManager.AddHp ();
			headSound.Play ();
			Destroy (gameObject);
		}
	}
}
