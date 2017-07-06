using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell me.");
		
		int max = 1000, min = 1;
		
		print("The highest number you can pick is " + max);
		print("And the minimum number you can pick is " + min);
		
		print("Is the number higher or lower than 500?");
		print("Press Up Arrow for higher, Down Arrow for lower and Return for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print("Up key was pressed");
		}
		
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			print("Down key was pressed");
		}
		
	}
}
