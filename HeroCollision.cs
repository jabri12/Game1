using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCollision : MonoBehaviour {
	//serialized fields
	[SerializeField]
	GameController gameController;
	[SerializeField]
	GameObject explosion;

	//private variable
	private AudioSource _lampSound;
	private AudioSource _enemySound;

	// Use this for initialization
	void Start () {
		_lampSound = gameObject.GetComponent<AudioSource> ();
		_enemySound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
	
		//play sound when coliding with lamp
		if (other.gameObject.tag.Equals ("lamp")) {
			Debug.Log ("Collision lamp\n");
			if (_lampSound != null) {
				_lampSound.Play ();
			}
			//Add Points
			Player.Instance.Score+=100;
		}else if (other.gameObject.tag.Equals ("enemy")){
			Debug.Log ("Collision enemy\n");
			}
			other.gameObject.GetComponent<RobotController> ()
				.Reset ();
			Player.Instance.Life--;
		}
	}

}
