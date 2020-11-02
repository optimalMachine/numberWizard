using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;


    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number. Don't tell me what it is...");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        Debug.Log("Tell me if you number is higher or lower than 500.");
        Debug.Log("Push up = higher, Push down = lower");
        max = max + 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is the number higher or lower than " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            Debug.Log("Up Arrow key was pressed.");


        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            Debug.Log("Down Arrow key was pressed.");

        }
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
            Debug.Log("I think I am a genius~~!!");
        }
    }
}
