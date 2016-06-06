using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TouchController : MonoBehaviour {

	PlayerManager playerManager;

	// Use this for initialization
	void Start () {
		playerManager = GameObject.Find ("Player").GetComponent<PlayerManager> ();
	}
	
	// Update is called once per frame
	void Update () {

		//タッチ入力
		if (Input.touchCount > 0)
		{	
			if (Input.touchCount == 2) {
				SceneManager.LoadScene ("Main");
			}
			
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began)
			{
				playerManager.ChangeDirection ();
			}

			else if (touch.phase == TouchPhase.Moved){ }
			else if (touch.phase == TouchPhase.Ended){ }
		}

		//キーボード入力
		if (Input.GetKeyDown (KeyCode.Space)) {
			playerManager.ChangeDirection ();
		}
	}
}
