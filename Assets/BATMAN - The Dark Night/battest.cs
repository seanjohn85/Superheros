using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battest : MonoBehaviour {

	public Animator anim;



	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("9"))
		{
			anim.Play("punching");
		}
		if(Input.GetKeyDown("8"))
		{
			anim.Play("walking");
		}
		if(Input.GetKeyDown("7"))
		{
			anim.Play("kicking");
		}
		if(Input.GetKeyDown("6"))
		{
			anim.Play("run");
		}
	
	}
}
