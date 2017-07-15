using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max, min, guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame()
	{
		max = 1000; min = 1; guess = 500;
		max = max + 1;
		
		print("===================================");
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell me.");
		
		print("The highest number you can pick is " + (max - 1));
		print("And the minimum number you can pick is " + min);
		
		print("Is the number higher or lower than " + guess + "?");
		print("Press Up Arrow for higher, Down Arrow for lower and Return for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print("Up key was pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("Down key was pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame();
		}
	}
	
	void NextGuess()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print("Press Up Arrow for higher, Down Arrow for lower and Return for equal");
	}
}
