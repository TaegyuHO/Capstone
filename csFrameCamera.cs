using UnityEngine;
using System.Collections;

public class csFrameCamera : MonoBehaviour {

	public GameObject Player;
	public GameObject _Camera;

	private Vector3 NewPosition;
	private Vector3 OriPosition;
	private float xPosition;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Erica");
		_Camera = GameObject.Find ("MultipurposeCameraRig");
		NewPosition = _Camera.transform.position;
		OriPosition = Player.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 camPos = _Camera.transform.localPosition;
		Vector3 gap = Player.transform.localPosition - camPos;
		_Camera.transform.localPosition += (gap / 20f);
		/*if (Player.transform.position != OriPosition) {
			NewPosition = Player.transform.position - OriPosition;
			xPosition = NewPosition.x;
		} 
		else
			xPosition = 0f;
		InvokeRepeating ("SetOrigin", 2f, 5f);*/
	}



}
