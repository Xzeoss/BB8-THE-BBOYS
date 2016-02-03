using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float moveSpeed;	//horizontal movespeed
	public float jumpHeight;
	public int gravity;
	bool grounded;	//detects if player has touched the ground to jump again
					//switch to raycast
	Vector3 startPos;	//position used for resetting the level
	GameObject[] platforms;	//array of platforms to change colour

	// Use this for initialization
	void Start () {

		grounded = true;
		gravity = 1;
		startPos = transform.position;
		platforms = GameObject.FindGameObjectsWithTag ("Platform");	//builds list of all platforms

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		Vector3 pos = transform.position;

		//handles left/right movement
		pos.x += Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;

		//handles the jump
		if (Input.GetKey (KeyCode.UpArrow) && grounded) {
			//add raycast code here
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, gravity) * jumpHeight, ForceMode2D.Impulse);
			grounded = false;
		}

		transform.position = pos;

	}

	void OnCollisionEnter2D(Collision2D col){

			grounded = true;	//switch to raycast on keypress

	}

	//called when player dies
	public void resetLocation(){

		transform.position = startPos;

	}

	public void resetColors(){
		Color c = Color.grey;
		for(int i = 0; i < platforms.Length; i++){
			platforms [i].GetComponent<SpriteRenderer> ().color = c;
		}

	}

	public void resetReality(){
		
	}
}
