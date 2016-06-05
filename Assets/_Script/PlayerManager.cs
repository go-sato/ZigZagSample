using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public GameObject scoreObj;
	public int score = 0;

	public AudioClip audioClip;
	AudioSource audioSource;

	MoveObject moveObject;
	public string state = "right";

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;

		moveObject = GetComponent<MoveObject> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("Point")) {
			audioSource.Play();
			Destroy (other.gameObject);
			scoreObj.SendMessage ("AddScore");
		}

		if (other.gameObject.CompareTag ("BadPoint")) {
			Application.LoadLevel ("Main");
			gameObject.SetActive (false);

		}
	}

	public void ChangeDirection(){
		switch (state) {
		case "right":
			moveObject.Move (180);
			state = "left";
			break;
		case "left":
			moveObject.Move (0f);
			state = "right";
			break;
		}
	}
}
