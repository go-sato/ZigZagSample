using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour {

	public int hp = 3;


	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text = "0";
	}

	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "HP:" + hp.ToString();
		if (hp == 0) {
			SceneManager.LoadScene ("Main");
		}
	}

	public void AddHp(){
		hp++;
	}

	public void SubHp(){
		hp--;
	}
}
