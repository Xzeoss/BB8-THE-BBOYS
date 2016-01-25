using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public bool moving;	//if the platform is a moving platform
	public bool dir;	//true is positive x movement, false is negative x movement
	public Vector3 startPos;
	public Vector3 endPos;
	public float moveSpeed;

	void Start(){

		transform.position = startPos;	//sets the start position for moving platforms. 
		if ((startPos.x - endPos.x) < 0)
			dir = true;	//sets the initial direction of the platform

	}

	void Update(){

		if (moving) {	

			Vector3 pos = transform.position;

			if (dir)
				pos.x += moveSpeed * Time.deltaTime;
			else
				pos.x -= moveSpeed * Time.deltaTime;
			if (pos.x > endPos.x)	//switches direction
				dir = false;
			if (pos.x < startPos.x)	//switches direction
				dir = true;

			transform.position = pos;

		}

	}

}
