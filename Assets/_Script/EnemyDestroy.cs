using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	public float lifeTime = 2.0f;
	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Death");
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("Point")) {
			//Application.LoadLevel ("Main");

			GameObject.Find("Score").SendMessage ("AddScore");
			audioSource.Play();
			Destroy (other.gameObject);

		}
	}

	private IEnumerator Death(){
		yield return new WaitForSeconds (lifeTime);  
		Destroy (gameObject);
	}
}
