using UnityEngine;
using System.Collections;

public class Spikestrip : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Player") {
			Player pl = col.gameObject.GetComponent<Player> ();
			pl.resetLocation();
		}

	}

}
