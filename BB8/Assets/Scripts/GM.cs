using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	GameObject[] platforms;

	// Use this for initialization
	void Start () {
	
		platforms = GameObject.FindGameObjectsWithTag ("Platform");
		for(int i = 0; i < platforms.Length; i++){

			if(platforms[i].GetComponent<Platform>().colour != 'N');
				platforms [i].GetComponent<Platform> ().turnOff ();

		}

	}
	
	// Update is called once per frame
	void Update () {
	
		Platform curPlatform;

		if(Input.GetKeyDown (KeyCode.Q)){	//turns on blue

			for(int i = 0; i < platforms.Length; i++){
				 
				curPlatform = platforms [i].GetComponent<Platform> ();

				if(curPlatform.colour == 'B' || curPlatform.colour == 'N'){
					
					curPlatform.turnOn ();

				}else{

					curPlatform.turnOff ();

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
		if(Input.GetKeyDown (KeyCode.A) ){

			for(int i = 0; i < platforms.Length; i++){

				platforms [i].GetComponent<Platform> ().turnOn ();

			}
		} //turns all on



	}
}
