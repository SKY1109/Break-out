using UnityEngine;
using System.Collections;

public class BottomController : MonoBehaviour {
	public GameObject gameOver;
	bool goTitle = false;

	void Update () {
		if (goTitle) {

			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel ("title");
			}
			if (Input.GetKeyDown (KeyCode.Return)) {
				Application.LoadLevel ("title");
			}
		}
	}

	void OnCollisionEnter(Collision col) {
		Destroy(col.gameObject);
	
		gameOver.SendMessage ("Lose");
		goTitle = true;
	}
}