using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizar : MonoBehaviour
{
    // Start is called before the first frame update

    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start()
    {

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Pick a number don't tell me what it is");
        Debug.Log("The highest number you can pick is: " +max);
        Debug.Log("The lowest is: " +min);
        Debug.Log("Let's Go!");
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed the up arrow!");
            min = guess;
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Debug.Log(guess);
            Debug.Log("You pressed the down arrow!");
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You have returned!");
        }






    }
}
