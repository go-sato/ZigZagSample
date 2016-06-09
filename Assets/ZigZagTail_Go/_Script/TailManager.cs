using UnityEngine;
using System.Collections;

public class TailManager : MonoBehaviour {

	public GameObject trail;
	public int trailSize = 50;
	Vector2 playerPos;
	GameObject[] players;
	Vector3[] startPos;
	Vector3[] pos;
	public GameObject trailEnd;

	SpriteRenderer tailSpriteRenderer;
	public Sprite tailL;
	public Sprite tailR;

	// Use this for initialization
	void Start () {
		players = new GameObject[trailSize+1];
		startPos = new Vector3[trailSize+1];
		pos = new Vector3[trailSize+1]; 

		players [0] = GameObject.Find ("Player");
		playerPos = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);

		for (int i = 1; i < trailSize; i++) {
			playerPos.y -= 0.05f; 
			players[i] = (GameObject)Instantiate (trail, playerPos, Quaternion.identity);	
			players [i].transform.parent = transform;
		}

		playerPos.y -= 0.05f; 
		players [trailSize] = (GameObject)Instantiate (trailEnd, playerPos, Quaternion.identity);	

		for (int i = 0; i < players.Length; i++) {
			startPos [i] = players [i].transform.position;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		for (int i = 0; i < players.Length; i++) {
			pos [i] = players [i].transform.position;
		}

		for (int i = 1; i < players.Length; i++) {
			pos [i-1].y = startPos [i].y;
			players [i].transform.position = pos [i - 1];
		}

		if (players [players.Length - 2].transform.position.x - players [players.Length-1].transform.position.x > 0) {
			players [players.Length-1].GetComponent<SpriteRenderer> ().sprite = tailR;
		} else {
			players [players.Length-1].GetComponent<SpriteRenderer> ().sprite = tailL;
		}
	}
}
