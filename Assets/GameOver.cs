using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	void Start () {
		gameObject.GetComponent<Text> ().enabled = false;
	}

	void Lose () {
		gameObject.GetComponent<Text> ().enabled = true;
	}
}
