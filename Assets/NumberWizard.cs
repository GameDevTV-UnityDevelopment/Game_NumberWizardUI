using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard: MonoBehaviour
{
    int max;
    int min;
    int guess;

    public int maxGuessesAllowed = 5;

    public Text text;

    /// <summary>
    /// Initialise
    /// </summary>
    void Start()
    {
        StartGame();
    }

    /// <summary>
    /// Start the game
    /// </summary>
    void StartGame()
    {
        max = 1000;
        min = 1;

        NextGuess();
    }

    /// <summary>
    /// Guesses a higher number
    /// </summary>
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    /// <summary>
    /// Guesses a lower number
    /// </summary>
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    /// <summary>
    /// Calculates the next guess
    /// </summary>
    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;

        if(maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
