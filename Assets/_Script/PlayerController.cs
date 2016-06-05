using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject scoreObj;
	public int score = 0;

	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
//		if (other.gameObject.CompareTag ("Block")) {
//			manager.SendMessage ("ReStart");
//			Destroy (gameObject);
//		}

		if (other.gameObject.CompareTag ("Point")) {
			audioSource.Play();
			Destroy (other.gameObject);
			scoreObj.SendMessage ("AddScore");
		}

		if (other.gameObject.CompareTag ("BadPoint")) {
			Application.LoadLevel ("Main");
			gameObject.SetActive (false);

			//scoreObj.SendMessage ("AddScore");
		}
	}

	private IEnumerator ReStart(){
		yield return new WaitForSeconds (2.0f);

	}
}
