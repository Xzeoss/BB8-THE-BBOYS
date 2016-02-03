using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	GameObject player;
	GameObject[] platforms;	//array of platforms to change colour

	// Use this for initialization
	void Start () {
	
		player = GameObject.Find ("Player");	//find the player object in the scene
		platforms = GameObject.FindGameObjectsWithTag ("Platform");	//builds list of all platforms 
		changePlatforms (Color.grey);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Player pl = player.GetComponent<Player> ();	//grabs the player script attached to player

		if (Input.GetKeyDown (KeyCode.R)) { //switches gravity
			player.GetComponent<Rigidbody2D> ().gravityScale *= -1;	//reverse gravity
			pl.gravity *= -1;	//changes gravity in player to reverse jump vector
			if (pl.gravity == -1)
				changePlatforms (Color.blue);	//changes map colour to blue
			else if (pl.gravity == 1)
				changePlatforms (Color.grey);	//changes map colour to grey
		}
		if (Input.GetKeyDown (KeyCode.S)) { //switches size to larger
			
			if(player.transform.localScale == Vector3.one){	//checking to see if normal size
				player.transform.localScale *= 2;	//doubles player size
				changePlatforms (Color.red); 	//changes map colour to red
			}else {
				player.transform.localScale = Vector3.one;	//revert player to scale
				changePlatforms (Color.grey); 	//change map colour to grey
			}

		}

		if (Input.GetKeyDown (KeyCode.A)) { //switches size to smaller
			if(player.transform.localScale == Vector3.one){	//checking to see if normal size
				player.transform.localScale /= 2;	//one half player size
				changePlatforms (Color.magenta); 	//changes map colour to magneta
			}else{
				player.transform.localScale = Vector3.one;	//revert player to scale
				changePlatforms (Color.grey); 	//change map colour to grey
			}

		}

		if (Input.GetKeyDown (KeyCode.G)) { //rotates the camera 90 degrees clockwise. 
			//may be added later
		}

	}

	//method goes through all the platforms and changes the colour
	void changePlatforms(Color c){

		for(int i = 0; i < platforms.Length; i++){

			platforms [i].GetComponent<SpriteRenderer> ().color = c;

		}

	}

	static void onDeath(GameObject player){
		
	}
}
