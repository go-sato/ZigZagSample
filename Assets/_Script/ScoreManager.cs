using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text = "0";
	}

	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = score.ToString();
	}

	public void AddScore(){
		score++;
	}
}
