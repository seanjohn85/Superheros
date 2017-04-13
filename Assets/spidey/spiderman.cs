using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//for text and canvas ui library elements
using UnityEngine.UI;
//to change the scene
using UnityEngine.SceneManagement;


[RequireComponent(typeof(AudioSource))]

//script for contoller for spiderman

public class spiderman : MonoBehaviour {
	
	//animater object
	public Animator anim;
	//score counter
	private int count;
	//score text
	public Text score;

	void Start ()
	{
		//sets the animater object to the animater controller of the object this script is assigned to
		anim = GetComponent<Animator> ();
		//sets count to 0 for the start of the game
		count = 0;
		//set display test
		DisplayCollectedQty ();
	}

	//collision detection function
	void OnTriggerEnter(Collider other) 
	{
		//checks if the collions is with a collectable with the spider tag
		if (other.gameObject.CompareTag("spider")) {
			//removes the eleement from play
			other.gameObject.SetActive(false);
			//increments the qty of collected spiders by 1
			count = count + 1;
			//play sound
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			//updates the value in the user display
			DisplayCollectedQty ();
		}
	}

	//set display test
	void DisplayCollectedQty (){
		///sets the score text
		score.text = "Score: " +count.ToString();

		//if the player collects 15 eleemnts load the win screen
		if (count >= 15)
		{
			//loads Win screen
			SceneManager.LoadScene (2);
		}
	}

	//event listeners for user key press
	void Update ()
	{
		//each keyboard input will trigger an animation (player movement)

		if(Input.GetKeyDown("w"))
		{
			anim.Play("crawl");
		}
		if(Input.GetKeyDown("s"))
		{
			anim.Play("fireball");
		}
		if(Input.GetKeyDown("d"))
		{
			anim.Play("kicking");
		}
		if(Input.GetKeyDown("a"))
		{
			anim.Play("swing");
		}
		if(Input.GetKeyDown("x"))
		{
			anim.Play("flip");
		}
		//arrow movement for walking
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			anim.Play ("walking");
		} 
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			anim.Play("left");
		}
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			anim.Play("right");
		}
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			anim.Play("moonwalk");
		}
	}


}
