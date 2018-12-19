using UnityEngine ;
using System.Collections ;

public class Ball1 : MonoBehaviour {
	private float speed = 15.0f;
	// Use this for initialization
	public GameObject gameClear;
	public int blockCt = 20;

	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward - transform.right )  * speed ,
			ForceMode.VelocityChange );

	}

	// Update is called once per frame
	void Update () {

		if (blockCt == 0) {

			GetComponent<Rigidbody> ().velocity = Vector3.zero;

			gameClear.SendMessage ("Win");

			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel ("title");
			}
			if (Input.GetKeyDown (KeyCode.Return)) {
				Application.LoadLevel ("title");
			}
		}
	}


	void OnCollisionEnter (Collision col){

		if (col.gameObject.tag == "Block") {
			blockCt -= 1;
		}
	}
}

