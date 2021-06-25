using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{
    //Counter used to display the player's current score
    public int scoreCounter;
    //Reference to the score counter
    public Text scoreText;
    //Counter used to display the player's lives
    public int livesCounter;
    //Reference to the live counter
    public Text livesText;
    //Reference to the game over screen
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the score counter to 0 at start
        scoreCounter = 0;
        //Sets the life counter to be 3
        livesCounter = 5;
    }

    public void AddScore(int multiplier)
    {
        //Adds the passed in amount of points to the score counter
        scoreCounter += multiplier;
    }

    public void AddLife(int amount)
    {
        //Adds to the life counter
        livesCounter += amount;
    }

    public void RemoveLife(int amount)
    {
        //Subtracts from the life counter
        livesCounter -= amount;
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the scoreboard to display the current score
        scoreText.text = "Score: " + scoreCounter;
        //Sets the life counter to display the current amount of lives
        livesText.text = "Lives: " + livesCounter;

        if (livesCounter <= 0)
            gameOver.SetActive(true);
    }
}
