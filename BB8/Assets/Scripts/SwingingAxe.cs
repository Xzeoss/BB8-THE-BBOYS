using UnityEngine;
using System.Collections;

public class SwingingAxe : MonoBehaviour {

	[SerializeField]
	float rotSpeed;
	int dir;

	// Use this for initialization
	void Start () {

		dir = 1;

	}
	
	// Update is called once per frame
	void Update () {

		//to ensure that the swinging axe doesnt switch early
		transform.Rotate (new Vector3 (0, 0, dir) * rotSpeed * Time.deltaTime);
		print (transform.rotation.z);
		if (transform.rotation.z > .7071608 || transform.rotation.z < 0)
			dir *= -1;

	}

	void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject.tag == "Player"){

			Player pl = col.gameObject.GetComponent<Player> ();
			pl.onDeath ();
		}

	}

}
