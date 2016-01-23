using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public float rotSpeed;
	public int gravity; //positive gravity is true
	bool posRot;	//sets the rotation direction based on movement when jumping
	bool grounded;
	Vector3 startPos;

	// Use this for initialization
	void Start () {

		grounded = true;
		gravity = 1;
		startPos = transform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		Vector3 pos = transform.position;

		//handles left right movement
		pos.x += Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		if (Input.GetAxis ("Horizontal") < 0)
			posRot = false;
		if (Input.GetAxis ("Horizontal") > 0)
			posRot = true;

		//handles the jump
		if (Input.GetKey (KeyCode.UpArrow) && grounded) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, gravity) * jumpHeight, ForceMode2D.Impulse);
			grounded = false;
		}

		transform.position = pos;

	}

	void OnCollisionEnter2D(Collision2D col){

			grounded = true;

	}

	public void resetLocation(){

		transform.position = startPos;

	}
}
