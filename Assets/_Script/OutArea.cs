using UnityEngine;
using System.Collections;

public class OutArea : MonoBehaviour {

	MoveObject moveObject;
	TouchController touchController;

	public string side;

	// Use this for initialization
	void Start () {
		moveObject = GameObject.Find("Player").GetComponent<MoveObject> ();
		touchController = GameObject.Find ("Player").GetComponent<TouchController> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other) {
		//		if (other.gameObject.CompareTag ("Block")) {
		//			manager.SendMessage ("ReStart");
		//			Destroy (gameObject);
		//		}

		if (other.gameObject.CompareTag ("Player")) {
			switch (side) {
			case "right":
				moveObject.Move (180);
				touchController.state = "left";
				break;
			case "left":
				moveObject.Move (0f);
				touchController.state = "right";
				break;
			}

//			Application.LoadLevel ("Main");
//			Destroy (other.gameObject);

		}

	}
}
