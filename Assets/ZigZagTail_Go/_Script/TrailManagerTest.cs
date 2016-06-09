using UnityEngine;
using System.Collections;

public class TrailManagerTest : MonoBehaviour {

	public float lifeTime = 2.0f;
	public string state;
	PlayerManager playerManager;
	SpriteRenderer mainSpriteRenderer;
	public Sprite tailL;
	public Sprite tailR;

	// Use this for initialization
	void Start () {
		playerManager = GameObject.Find ("Player").GetComponent<PlayerManager> ();
		mainSpriteRenderer = GetComponent<SpriteRenderer> ();
		StartCoroutine ("ChangeTail");
		StartCoroutine ("Destroy");

	}

	// Update is called once per frame
	void Update () {
		state = playerManager.state;
	}

	private IEnumerator ChangeTail(){
		yield return new WaitForSeconds (lifeTime - 0.05f);
		switch (state) {
		case "right":
			mainSpriteRenderer.sprite = tailL;
			break;
		case "left":
			mainSpriteRenderer.sprite = tailR;
			break;
		}

	}

	private IEnumerator Destroy(){
		yield return new WaitForSeconds (lifeTime); 
		Destroy (gameObject);
	}
}
