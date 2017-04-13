using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//for text and canvas ui library elements
using UnityEngine.UI;
//to change the scene
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	//the quit sub menu reference
	public Canvas quit;
	//button objects 
	public Button play;
	public Button exit;

	// Use this for initialization
	void Start () {
		//gets the elemeents from the UI
		quit = quit.GetComponent<Canvas> ();
		play = play.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
		//hides the quit sub menu
		quit.enabled = false;
		
	}

	//when a user press quit
	public void ExitPress() {
		//display quit sub menu
		quit.enabled = true; 
		//disable standard btns
		play.enabled = false; 
		exit.enabled = false;
	}

	//When the user hits no on quit menu dismiss this menu
	public void NoPress(){
		//hide this menu
		quit.enabled = false; 
		//reenable normal btns
		play.enabled = true; 
		exit.enabled = true;
	}

	//start the game
	public void StartLevel (){
		//will load scene 1 the 1st leevl
		SceneManager.LoadScene (1); 
	}

	//when the user selects quit game
	public void ExitGame (){
		//will exit the app
		Application.Quit();

	}

}
