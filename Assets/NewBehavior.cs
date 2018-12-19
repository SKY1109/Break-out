using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehavior : MonoBehaviour {

	　　private float accel = 10.0f;
    bool onDown1;
    bool onDown2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		/*this.GetComponent<Rigidbody> ().AddForce (
			transform.right * Input.GetAxisRaw ("Horizontal") * accel,
			ForceMode.Impulse);*/

		if (Input.GetKey (KeyCode.RightArrow) ) {
			transform.position += Vector3.right * 0.3f;;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * 0.3f;
		}
		if (transform.position.x >= 11.0f) {
			transform.position = new Vector3 (11.0f, transform.position.y, transform.position.z);
			}
		if (transform.position.x <= -11.5f) {
			transform.position = new Vector3 (-11.5f, transform.position.y, transform.position.z);
		}

        if (onDown1)
        {
            transform.position += Vector3.right * 0.3f;
        }
        if (onDown2)
        {

            transform.position += Vector3.left * 0.3f;
        }


	}
    public void OnRightButton()
    {
        onDown1 = true;
    }

    public void OnRightUp()
    {
        onDown1 = false;
    }

    public void OnLeftButton()
    {
        onDown2 = true;
    }

    public void OnLeftUp()
    {
        onDown2 = false;
    }
}
