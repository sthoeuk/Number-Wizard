using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess;

    // Use this for initialization
    void Start () {
        

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Highest number you can pick is " + max);
        Debug.Log("Lowest number you can pick is " + min);
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow was pressed.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I knew it!!");
            max = 1000;
            min = 1;
            guess = (max + min) / 2;
            Debug.Log("Let's play again...");
            Debug.Log("is your number higher or lower than " + guess +"?");
        }
    }
}
