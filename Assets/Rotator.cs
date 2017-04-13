using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//creates a spinning movement for the colectable spider sign
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
