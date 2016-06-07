using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	MoveObject moveObject;
	public string state = "right";
	int HP = 3;

	SpriteRenderer mainSpriteRenderer;
	public Sprite playerL;
	public Sprite playerR;

	// Use this for initialization
	void Start () {
		moveObject = GetComponent<MoveObject> ();
		mainSpriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		//transform.rotation = Quaternion.Euler(0, 0, -20);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

	}

	public void ChangeDirection(){
		switch (state) {
		case "right":
			mainSpriteRenderer.sprite = playerL;
//			transform.rotation = Quaternion.Euler(0, 0, 40);
			moveObject.Move (180);
			state = "left";
			break;
		case "left":
			mainSpriteRenderer.sprite = playerR;
//			transform.rotation = Quaternion.Euler(0, 0, -40);
			moveObject.Move (0f);
			state = "right";
			break;
		}
	}

	public void damage(){
		HP--;
		if (HP == 0) {
			Destroy (gameObject);
		}
	}
}
