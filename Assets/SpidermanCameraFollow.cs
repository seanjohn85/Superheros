using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpidermanCameraFollow : MonoBehaviour {

	//refence object to the spiderman player
	public GameObject spiderRef;  

	//var to store offsct between spiderman and camera
	private Vector3 offset;         

	// Use this for initialization
	void Start () 
	{
		//set offset to the distance between spiderman and the camera
		offset = transform.position - spiderRef.transform.position;
	}
	    
	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		//Move the position of the camera when the player moves
		transform.position = spiderRef.transform.position + offset;
	}
}