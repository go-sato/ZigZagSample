using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public float direction = 40.0f;
	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
		Move (direction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move(float direction){
		Vector2 v;
		v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
		v.y = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;

		Rigidbody2D rd = GetComponent<Rigidbody2D>();
		rd.velocity = v;
	}
		
}
