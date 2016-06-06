using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComboManager : MonoBehaviour {

	int comboCount = 0;  //総コンボ数
	float comboSpan = 0.0f;  //コンボの間隔
	float comboStart = 0.0f;  //前のPointに当たった時間
	public float threshold = 0.0f;  //コンボとする間隔の閾値
	float time = 0.0f;
	public GameObject rotationTrail;

	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text = "";
	}
	
	// Update is called once per frame
	void Update () {
		time = Time.time;
		if (comboCount >= 2) {
			this.GetComponent<Text> ().text = comboCount.ToString () + "combo";
		} else {
			this.GetComponent<Text>().text = "";
		}

		comboSpan = time - comboStart;

		if (comboSpan > 0.6) {
			this.GetComponent<Text>().text = "";
			comboCount = 0;
			comboSpan = 0.0f;
		}

		if (comboCount == 3) {
			AllGetOn ();
		}
	}

	public void GetPoint(){
		if (comboCount == 0) {
			comboStart = time;
			comboCount++;
		} else {
			
			if (comboSpan <= threshold) {
				comboCount++;
				comboStart = time;
			} else {
				comboCount = 0;
				comboSpan = 0.0f;
			}
		}
	}

	void AllGetOn(){
		rotationTrail.SetActive (true);
		StartCoroutine ("AllGetOff");
	}

	private IEnumerator AllGetOff(){
		yield return new WaitForSeconds (2.0f);  
		rotationTrail.SetActive (false);
	}
}
