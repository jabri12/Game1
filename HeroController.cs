using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	[SerializeField]
	private float speed = 7f;
	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightX;
	[SerializeField]
	private float upY;
	[SerializeField]
	private float downY;

	private Transform _transform;
	private Vector2 _currentPos;


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		_currentPos = _transform.position;

		if (Input.GetKey (KeyCode.A)) {
			//left arrow moves left
			_currentPos -= new Vector2(speed, 0);
		}
			if (Input.GetKey (KeyCode.D)) {
			//left arrow moves right
			_currentPos += new Vector2(speed, 0);
		}

		if (Input.GetKey (KeyCode.W)) {
			//moves up
			_currentPos += new Vector2(0, speed);
		}

			if (Input.GetKey (KeyCode.S)) {
			//moves down
			_currentPos -= new Vector2(0, speed);
		}
		CheckBounds ();
		_transform.position = _currentPos;
	}

	private void CheckBounds(){
		//Declares Boundaries
		if (_currentPos.x < leftX) {
			_currentPos.x = leftX;
		}

		if (_currentPos.x > rightX) {
			_currentPos.x = rightX;
		}

		if (_currentPos.y > upY) {
			_currentPos.y = upY;
		}

		if (_currentPos.y < downY) {
			_currentPos.y = downY;
		}
	}
}
