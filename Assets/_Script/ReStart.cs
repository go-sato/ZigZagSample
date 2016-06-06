using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				SceneManager.LoadScene ("Main");
			}
		}
	}
}
