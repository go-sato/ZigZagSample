using UnityEngine;

public class Background : MonoBehaviour
{
	// スクロールするスピード
	public float speed = 0.1f;
	float beforeValue = 0.0f;
	float difference;

	void Update ()
	{
		// 時間によってYの値が0から1に変化していく。1になったら0に戻り、繰り返す。
		float y = Mathf.Repeat (Time.time * speed / 10, 1);

		difference = y - beforeValue;

		if (Mathf.Abs(difference) >= 0.8) {
			//n回ループしたら、shaderのmaterialを変更
			//1周終わったら、再度shaderのmaterialを変更
			Debug.Log (y);
		}
	
		// Yの値がずれていくオフセットを作成
		Vector2 offset = new Vector2 (0, y);

		// マテリアルにオフセットを設定する
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);

		beforeValue = y;
	}
}