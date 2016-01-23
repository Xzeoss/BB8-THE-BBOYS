using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	GameObject player;
	GameObject[] platforms;	//array of platforms to change colour

	// Use this for initialization
	void Start () {
	
		player = GameObject.Find ("Player");
		platforms = GameObject.FindGameObjectsWithTag ("Platform");
		changePlatforms (Color.grey);

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.R)) { //switches gravity
			//change colour of platforms
		 //changes platforms to blue
			player.GetComponent<Rigidbody2D> ().gravityScale *= -1;
			Player pl = player.GetComponent<Player> ();
			pl.gravity *= -1;
			if (pl.gravity == -1)
				changePlatforms (Color.blue);
			else if (pl.gravity == 1)
				changePlatforms (Color.grey);
		}
		if (Input.GetKeyDown (KeyCode.S)) { //switches size
			if(player.transform.localScale == Vector3.one){	//scale up
				player.transform.localScale *= 2;
				changePlatforms (Color.red); 
			}else{
				player.transform.localScale = Vector3.one;
				changePlatforms (Color.grey); 
			}

		}

	}

	void changePlatforms(Color c){

		for(int i = 0; i < platforms.Length; i++){

			platforms [i].GetComponent<SpriteRenderer> ().color = c;

		}

	}
}
