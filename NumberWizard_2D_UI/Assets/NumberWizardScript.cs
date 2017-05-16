using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //to add UI elements, e.g. Text

public class NumberWizardScript : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;

    int maxGuessesAllowed = 10;

    public Text foobar; //foobar is the placeholder in the Game Scene

    void Start () {
        StartGame();
    }
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max = max + 1;
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        foobar.text = guess.ToString(); 
        maxGuessesAllowed = -1; //reduce maxGuessedAllowed
        if(maxGuessesAllowed <= 0)
            {
            SceneManager.LoadScene("Win"); //move to Win Screen, if computer couldn't guess your number in 10 attempts
            }
        print("higher or lower than " + guess);
        
    }
}
