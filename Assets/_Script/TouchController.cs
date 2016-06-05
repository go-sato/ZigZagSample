using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public string state = "right";
	MoveObject moveObject;

	// Use this for initialization
	void Start () {
		moveObject = GetComponent<MoveObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began)
			{
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
			else if (touch.phase == TouchPhase.Moved)
			{
				// タッチ移動
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				// タッチ終了
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			switch (state) {
			case "right":
				moveObject.Move (180);
				state = "left";
				break;
			case "left":
				moveObject.Move (0);
				state = "right";
				break;
			}
		}
	}
}
