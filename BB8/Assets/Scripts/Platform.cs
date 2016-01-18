using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public char colour;
	[SerializeField]
	Sprite[] platformSprites;

	public void turnOff(){

		//turn off collider
		//switch sprite to transparent

		GetComponent<BoxCollider2D>().enabled = false;
		GetComponent<SpriteRenderer> ().sprite = platformSprites [1]; //changes sprite to transparent

	}

	public void turnOn(){

		GetComponent<BoxCollider2D>().enabled = true;
		GetComponent<SpriteRenderer> ().sprite = platformSprites [0];

	}

}
