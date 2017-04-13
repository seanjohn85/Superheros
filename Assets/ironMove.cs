using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ironMove : MonoBehaviour {

		public Animator anim;



		void Start ()
		{
			anim = GetComponent<Animator> ();
		}


		void Update ()
		{


		if(Input.GetKeyDown("1"))
		{
			anim.Play("flying");
		}
			if(Input.GetKeyDown("v"))
			{
			anim.Play("victory");
			}
		if(Input.GetKeyDown("n"))
		{
			anim.Play("walking");
		}




	}

}