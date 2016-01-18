using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	GameObject[] platforms;

	// Use this for initialization
	void Start () {
	
		platforms = GameObject.FindGameObjectsWithTag ("Platform");	//an array of all the platforms in game
		for(int i = 0; i < platforms.Length; i++){
			
			platforms [i].GetComponent<Platform> ().turnOff ();	//sets them all to "off"

		}

	}
	
	// Update is called once per frame
	void Update () {
	
		Platform curPlatform;

		if(Input.GetKeyDown (KeyCode.Q)){	//turns on blue

			for(int i = 0; i < platforms.Length; i++){
				 
				curPlatform = platforms [i].GetComponent<Platform> ();	//accessing the platform script
				//thats attached to each platform object

				if(curPlatform.colour == 'B'){	//turns on all blue platforms
					
					curPlatform.turnOn ();	

				}else{

					curPlatform.turnOff ();	//turn the rest off

				}

			}

		}
		if(Input.GetKeyDown (KeyCode.W) ){	//turns on green

			for(int i = 0; i < platforms.Length; i++){

				curPlatform = platforms [i].GetComponent<Platform> ();

				if(curPlatform.colour == 'G'){

					curPlatform.turnOn ();

				}else{

					curPlatform.turnOff ();

				}

			}

		}
		if(Input.GetKeyDown (KeyCode.E) ){	//turns on red

			for(int i = 0; i < platforms.Length; i++){

				curPlatform = platforms [i].GetComponent<Platform> ();

				if(curPlatform.colour == 'R'){

					curPlatform.turnOn ();

				}else{

					curPlatform.turnOff ();

				}

			}

		}
		if(Input.GetKeyDown (KeyCode.R) ){	//turns on yellow

			for(int i = 0; i < platforms.Length; i++){

				curPlatform = platforms [i].GetComponent<Platform> ();

				if(curPlatform.colour == 'Y'){

					curPlatform.turnOn ();

				}else{

					curPlatform.turnOff ();

				}

			}

		}
		if(Input.GetKeyDown (KeyCode.A) ){	//turns on all platforms

			for(int i = 0; i < platforms.Length; i++){

				platforms [i].GetComponent<Platform> ().turnOn ();

			}
		} //turns all on



	}
}
