using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField]
	float moveSpeed;
	[SerializeField]
	float jumpHeight;
	bool grounded;

	// Use this for initialization
	void Start () {

		grounded = true;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		Vector3 pos = transform.position;

		//handles left right movement
		if(Input.GetKey (KeyCode.LeftArrow))
			pos.x -= moveSpeed * Time.deltaTime;
		if (Input.GetKey (KeyCode.RightArrow))
			pos.x += moveSpeed * Time.deltaTime;

		//handles the jump
		if (Input.GetKey (KeyCode.UpArrow) && grounded) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpHeight, ForceMode2D.Impulse);
			grounded = false;
		}

		transform.position = pos;

	}

	void OnCollisionEnter2D(Collision2D col){

		//when the player touches a platform it resets jump
		if(col.gameObject.tag == "Platform" || col.gameObject.tag == "Respawn"){

			grounded = true;

		}

	}
}
