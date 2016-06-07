using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	MoveObject moveObject;
	public string state = "right";
	int HP = 3;

	SpriteRenderer mainSpriteRenderer;
	public Sprite headL;
	public Sprite headR;
	SpriteRenderer earSpriteRenderer;
	public Sprite earL;
	public Sprite earR;

	// Use this for initialization
	void Start () {
		moveObject = GetComponent<MoveObject> ();
		mainSpriteRenderer = GetComponent<SpriteRenderer> ();
		earSpriteRenderer = GameObject.Find ("Ear").GetComponent<SpriteRenderer>();
		//transform.rotation = Quaternion.Euler(0, 0, -20);
	}
	
	// Update is called once per frame
	void Update () {
		Clamp();
	}

	void OnTriggerEnter2D(Collider2D other) {

	}

	public void ChangeDirection(){
		switch (state) {
		case "right":
			mainSpriteRenderer.sprite = headL;
			earSpriteRenderer.sprite = earL;
//			transform.rotation = Quaternion.Euler(0, 0, 40);
			moveObject.Move (180);
			state = "left";
			break;
		case "left":
			mainSpriteRenderer.sprite = headR;
			earSpriteRenderer.sprite = earR;
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

	void Clamp ()
	{
		// 画面左下のワールド座標をビューポートから取得
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		// 画面右上のワールド座標をビューポートから取得
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		// プレイヤーの座標を取得
		Vector2 pos = transform.position;

		if (pos.x < min.x || max.x < pos.x) {
			ChangeDirection ();
		}

		// プレイヤーの位置が画面内に収まるように制限をかける
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);

		// 制限をかけた値をプレイヤーの位置とする
		transform.position = pos;
	}
}

