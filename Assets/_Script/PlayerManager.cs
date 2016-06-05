using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	MoveObject moveObject;
	public string state = "right";
	int HP = 3;

	// Use this for initialization
	void Start () {
		moveObject = GetComponent<MoveObject> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

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

	public void damage(){
		HP--;
		if (HP == 0) {
			Destroy (gameObject);
		}
	}
}
