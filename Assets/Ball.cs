using UnityEngine ;
using System.Collections ;

public class Ball : MonoBehaviour {
	private float speed = 10.0f;
	// Use this for initialization
	public GameObject gameClear;
	public int blockCt = 20;
    int resetcount;
    Vector3 ballpos;
		
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right )  * speed ,
			ForceMode.VelocityChange );
        resetcount = 0;
        ballpos = transform.position;
	
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

    public void BallReset()
    {
        resetcount += 1;

        if(resetcount<4)
        {
            ballpos = new Vector3(1, 0, 20);
            transform.position = ballpos;

            GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);

        }
    }
 }

