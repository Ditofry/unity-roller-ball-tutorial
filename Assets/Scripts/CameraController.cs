using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame just as update is, 
	// but late update is run after all the processing in the regular update 
	// function has completed.  It's a good choice for tracking because we 
	// want to make sure that we're moving the camera based on the very most
	// recent behaviour of our player object.
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
