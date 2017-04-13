using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpideyMovement : MonoBehaviour {
	public Animator anim;



	void Start ()
	{
		anim = GetComponent<Animator> ();
	}


	void Update ()
	{
		
		if(Input.GetKeyDown("a"))
		{
			anim.Play("flip");
		}
		if(Input.GetKeyDown("s"))
		{
			anim.Play("crawl");
		}
		if(Input.GetKeyDown("w"))
		{
			anim.Play("Swinging");
		}
		if(Input.GetKeyDown("z"))
		{
			anim.Play("back");
		}

	}
}
	
