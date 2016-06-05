using UnityEngine;
using System.Collections;

public class TrailManager : MonoBehaviour {

	public float lifeTime = 2.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Destroy");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private IEnumerator Destroy(){
		yield return new WaitForSeconds (lifeTime);  
		Destroy (gameObject);
	}
}
