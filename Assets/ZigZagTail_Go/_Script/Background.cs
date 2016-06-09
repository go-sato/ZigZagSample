using UnityEngine;

public class Background : MonoBehaviour
{
	// スクロールするスピード
	public float speed = 0.1f;
	float beforeValue = 0.0f;
	float difference;
	public Texture textureA;
	public Texture textureB;
	float scrollCount = 0;
	public GameObject middle;
	public int changeCount = 3;

	void Start(){
		scrollCount = 0;
		GetComponent<Renderer>().material.mainTexture = textureA;
	}

	void Update ()
	{
		// 時間によってYの値が0から1に変化していく。1になったら0に戻り、繰り返す。
		float y = Mathf.Repeat (Time.time * speed / 10, 1);
		difference = y - beforeValue;

		if (Mathf.Abs(difference) >= 0.8) {
			scrollCount++;
			if (scrollCount == changeCount) {
				middle.SetActive (true);
			}
			if (scrollCount == changeCount + 1) {
				GetComponent<Renderer>().material.mainTexture = textureB;
			}
			if (scrollCount == changeCount + 2) {
				middle.SetActive (false);
			}
				
		}
	
		// Yの値がずれていくオフセットを作成
		Vector2 offset = new Vector2 (0, y);

		// マテリアルにオフセットを設定する
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);

		beforeValue = y;
	}
}