using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour {
	//public
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;
	[SerializeField]
	private float startY;
	[SerializeField]
	private float endY;

	//private
	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		Reset ();
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_currentPos = _transform.position;

		_currentPos -= new Vector2 (speed, 0);

		if (_currentPos.x < endX) {

			Reset ();
		
		}

		_transform.position = _currentPos;
	}

	private void Reset(){
		//how the lamp loads each frame
		float x = Random.Range (startY, endY);
		float dy = Random.Range (100, 0);
		_currentPos = new Vector2 (x, startY+dy);
	}
}
