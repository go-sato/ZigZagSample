using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComboManager : MonoBehaviour {

	int comboCount = 0;
	float comboSpan = 0.0f;
	float comboStart = 0.0f;
	public float threshold = 0.0f;

	float time = 0.0f;

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
}
